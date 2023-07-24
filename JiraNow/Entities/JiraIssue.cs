using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    internal class JiraIssue
    {
        public JiraIssue() { }
        public int ID { get; set; }
        public string Key { get; set; }
        public List<JiraIssue> ChildIssues { get; set; }
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public int ParentIssueID { get; set; }
        public int IssueTypeID { get; set; } // us, task, etc
        public string IssueTypeName { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }

        public static JiraIssue Parse(string json)
        {
            var issue = new JiraIssue();
            JObject jobject = JObject.Parse(json);
            JObject jfields = (JObject)jobject["fields"];

            issue.ID = (int)jobject["id"];
            issue.Key = (string)jobject["key"];

            issue.ProjectID = (int)jfields["project"]["id"];
            issue.ProjectName = (string)jfields["project"]["name"];
            if (jfields.ContainsKey("parent"))
            {
                issue.ParentIssueID = (int)jfields["parent"]["id"];
            }
            issue.IssueTypeID = (int)jfields["issuetype"]["id"];
            issue.IssueTypeName = (string)jfields["issuetype"]["name"];
            issue.Description = (string)jfields["description"];
            issue.Summary = (string)jfields["summary"];

            return issue;
        }
    }
}
