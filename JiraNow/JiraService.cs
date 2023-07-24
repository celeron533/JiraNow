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
        string baseUri, cookiesStr;
        public JiraService(string baseUri, string cookiesStr)
        {
            this.baseUri = baseUri;
            this.cookiesStr = cookiesStr;
        }

        public async Task<JiraIssue> GetIssue(string issueID, bool includeDirectChild = false)
        {
            JiraApi api = new JiraApi(baseUri, cookiesStr);
            JiraIssue issue = null;
            JiraMessage issueMessage = await api.GetIssueByIdAsync(issueID);
            if (issueMessage.isSuccess)
            {
                issue = JiraIssue.Parse(issueMessage.jsonMessage);
                if (includeDirectChild)
                {
                    //todo: extract the logic
                    JiraMessage searchResultMessage = await api.SearchIssue($"parent={issue.Key}");
                    if (searchResultMessage.isSuccess)
                    {
                        issue.ChildIssues = JiraSearchResult.Parse(searchResultMessage.jsonMessage).Issues;
                    }
                }
            }

            return issue;
        }


    }
}
