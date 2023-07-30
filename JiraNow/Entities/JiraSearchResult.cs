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
    public class JiraSearchResult
    {
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
        [JsonIgnore]
        public string ErrorMessage { get; set; }

        [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
        public string Expand { get; set; }

        [JsonProperty("startAt", NullValueHandling = NullValueHandling.Ignore)]
        public long StartAt { get; set; }

        [JsonProperty("maxResults", NullValueHandling = NullValueHandling.Ignore)]
        public long MaxResults { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long Total { get; set; }

        [JsonProperty("issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<JiraIssue> Issues { get; set; }

        public static JiraSearchResult Parse(JiraMessage jiraMessage)
        {
            return Parse(jiraMessage.jsonMessage, jiraMessage.httpStatusCode);
        }

        public static JiraSearchResult Parse(string json, HttpStatusCode httpStatusCode = 0)
        {
            var searchResult = new JiraSearchResult();
            if (httpStatusCode > 0)
            {
                searchResult.StatusCode = httpStatusCode;
            }

            if ((int)httpStatusCode < 200 || (int)httpStatusCode > 299)
            {
                searchResult.ErrorMessage = json;
                return searchResult;
            }

            searchResult = JsonUtil.Deserialize<JiraSearchResult>(json);
            searchResult.StatusCode = httpStatusCode;
            return searchResult;
        }
    }
}
