//https://app.quicktype.io/?l=csharp

using System;
using System.Collections.Generic;

using System.Globalization;
using System.Net;
using JiraNow.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JiraNow.Entities
{
    public class JiraIssue
    {
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
        [JsonIgnore]
        public string ErrorMessage { get; set; }
        [JsonIgnore]
        public IList<JiraIssue> ChildIssues { get; set; }

        [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
        public string Expand { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Fields Fields { get; set; }


        public static JiraIssue Parse(JiraMessage jiraMessage)
        {
            return Parse(jiraMessage.jsonMessage, jiraMessage.httpStatusCode);
        }

        public static JiraIssue Parse(string json, HttpStatusCode httpStatusCode = 0)
        {
            var issue = new JiraIssue();
            if (httpStatusCode > 0)
            {
                issue.StatusCode = httpStatusCode;
            }

            if ((int)httpStatusCode < 200 || (int)httpStatusCode > 299)
            {
                issue.ErrorMessage = json;
                return issue;
            }

            issue = JsonUtil.Deserialize<JiraIssue>(json);
            issue.StatusCode = httpStatusCode;
            return issue;
        }

    }

}
