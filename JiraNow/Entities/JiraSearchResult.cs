using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    internal class JiraSearchResult
    {
        public JiraSearchResult() { }
        public int StartAt { get; set; }
        public int MaxResults { get; set; }
        public int Total { get; set; }
        public List<JiraIssue> Issues { get; set; }

        public static JiraSearchResult Parse(string json)
        {
            var result = new JiraSearchResult();
            JObject jobject = JObject.Parse(json);
            result.StartAt = (int)jobject["startAt"];
            result.MaxResults = (int)jobject["maxResults"];
            result.Total = (int)jobject["total"];
            result.Issues = new List<JiraIssue>();
            var jissues =jobject["issues"].ToList();
            foreach (JObject jissue in jissues)
            {
                result.Issues.Add(JiraIssue.Parse(jissue.ToString()));
            }


            return result;
        }
    }
}
