using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    internal class JiraSearchResult1
    {
        public JiraSearchResult1() { }

        public HttpStatusCode StatusCode { get; set; }
        public string ErrorMessage { get; set; }

        public int StartAt { get; set; }
        public int MaxResults { get; set; }
        public int Total { get; set; }
        public List<JiraIssue1> Issues { get; set; }

        public static JiraSearchResult1 Parse(JiraMessage jiraMessage)
        {
            return Parse(jiraMessage.jsonMessage, jiraMessage.httpStatusCode);
        }

        public static JiraSearchResult1 Parse(string json, HttpStatusCode statusCode = 0)
        {
            var result = new JiraSearchResult1();
            if (statusCode > 0) 
            {
                result.StatusCode = statusCode;
            }
            if((int)statusCode<200 || (int)statusCode >299)
            {
                result.ErrorMessage = json;
                return result;
            }
            
            JObject jobject = JObject.Parse(json);
            result.StartAt = (int)jobject["startAt"];
            result.MaxResults = (int)jobject["maxResults"];
            result.Total = (int)jobject["total"];
            result.Issues = new List<JiraIssue1>();
            var jissues =jobject["issues"].ToList();
            foreach (JObject jissue in jissues)
            {
                result.Issues.Add(JiraIssue1.Parse(jissue.ToString()));
            }


            return result;
        }
    }
}
