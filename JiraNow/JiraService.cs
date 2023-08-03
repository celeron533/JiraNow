using JiraNow.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace JiraNow
{
    internal class JiraService
    {
        JiraApi api;

        Uri hostUri;
        string cookiesStr;

        public JiraService(Settings settings)
        {
            this.hostUri = new Uri(settings.HostString);
            this.cookiesStr = settings.CookiesString;
            api = new JiraApi(hostUri, cookiesStr);
        }

        public async Task<JiraIssue> GetIssue(string issueID, bool includeDirectChild = true)
        {
            JiraIssue issue = null;
            JiraMessage issueMessage = await api.GetIssueByIdAsync(issueID);

            issue = JiraIssue.Parse(issueMessage);
            if (includeDirectChild && string.IsNullOrEmpty(issue.ErrorMessage))
            {
                issue.ChildIssues = await GetChildIssues(issue);
            }
            return issue;
        }

        public async Task<IList<JiraIssue>> GetChildIssues(JiraIssue parentIssue)
        {
            JiraMessage searchResultMessage = await api.SearchIssue($"parent={parentIssue.Key}");
            return JiraSearchResult.Parse(searchResultMessage).Issues?.OrderBy(i=>i.Key).ToList();
        }

        public async Task CopyChildIssues(string sourceIssueId, string destIssueId)
        {
            var getSourceIssueTask = GetIssue(sourceIssueId, true);
            var getDestIssueTask = GetIssue(destIssueId, true);
            await Task.WhenAll(getSourceIssueTask, getDestIssueTask);
            JiraIssue sourceIssue = getSourceIssueTask.Result;
            JiraIssue destIssue = getDestIssueTask.Result;
            await CopyChildIssues(sourceIssue, destIssue);
        }

        public async Task CopyChildIssues(JiraIssue sourceIssue, JiraIssue destIssue)
        {
            //validation
            if (!string.IsNullOrEmpty(sourceIssue.ErrorMessage) || !string.IsNullOrEmpty(destIssue.ErrorMessage))
            {
                throw new Exception("Error when fetching the issue");
            }

            if (sourceIssue.Fields.Issuetype.Id != destIssue.Fields.Issuetype.Id)
            {
                throw new NotSupportedException("Source and destination issue type are different");
            }

            IList<JiraIssue> destNewChildIssues = new List<JiraIssue>();

            foreach (var child in sourceIssue.ChildIssues)
            {
                JiraIssue newChild = new JiraIssue
                {
                    Fields = new Fields
                    {
                        Parent = new Parent { Id = destIssue.Id },
                        Project = new Project { Id = child.Fields.Project.Id },
                        Issuetype = new Issuetype { Id = child.Fields.Issuetype.Id },
                        //Comment = new Comment { Comments = child.Fields.Comment.Comments },
                        Description = child.Fields.Description,
                        Labels = child.Fields.Labels,
                        Summary = child.Fields.Summary
                    }
                };
                destNewChildIssues.Add(newChild);
            }

            // create the new issues in sequence to ensure their new ID are in the order
            foreach (var child in destNewChildIssues)
            {
                await api.CreateIssue(child);
            }

        }
    }
}
