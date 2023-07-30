using JiraNow.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JiraNow
{
    internal class JiraService
    {
        Uri hostUri;
        string cookiesStr;
        public JiraService(Settings settings)
        {
            this.hostUri = new Uri(settings.HostString);
            this.cookiesStr = settings.CookiesString;
        }

        public async Task<JiraIssue1> GetIssue(string issueID, bool includeDirectChild = false)
        {
            JiraApi api = new JiraApi(hostUri, cookiesStr);
            JiraIssue1 issue = null;
            JiraMessage issueMessage = await api.GetIssueByIdAsync(issueID);

            issue = JiraIssue1.Parse(issueMessage);
            if (includeDirectChild && string.IsNullOrEmpty(issue.ErrorMessage))
            {
                //todo: extract the logic
                JiraMessage searchResultMessage = await api.SearchIssue($"parent={issue.Key}");

                issue.ChildIssues = JiraSearchResult1.Parse(searchResultMessage.jsonMessage).Issues;
            }
            return issue;
        }


        public async Task CopyChildIssues(JiraIssue1 sourceIssue, JiraIssue1 destIssue)
        {
            throw new NotImplementedException();
        }
    }
}
