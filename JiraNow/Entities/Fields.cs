using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    public class Fields
    {
        [JsonProperty("statuscategorychangedate", NullValueHandling = NullValueHandling.Ignore)]
        public string Statuscategorychangedate { get; set; }

        [JsonProperty("issuetype", NullValueHandling = NullValueHandling.Ignore)]
        public Issuetype Issuetype { get; set; }

        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Parent Parent { get; set; }

        [JsonProperty("timespent", NullValueHandling = NullValueHandling.Ignore)]
        public object Timespent { get; set; }

        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public Project Project { get; set; }

        [JsonProperty("fixVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> FixVersions { get; set; }

        [JsonProperty("aggregatetimespent", NullValueHandling = NullValueHandling.Ignore)]
        public object Aggregatetimespent { get; set; }

        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public object Resolution { get; set; }

        [JsonProperty("resolutiondate", NullValueHandling = NullValueHandling.Ignore)]
        public object Resolutiondate { get; set; }

        [JsonProperty("workratio", NullValueHandling = NullValueHandling.Ignore)]
        public long Workratio { get; set; }

        [JsonProperty("issuerestriction", NullValueHandling = NullValueHandling.Ignore)]
        public Issuerestriction Issuerestriction { get; set; }

        [JsonProperty("lastViewed", NullValueHandling = NullValueHandling.Ignore)]
        public string LastViewed { get; set; }

        [JsonProperty("watches", NullValueHandling = NullValueHandling.Ignore)]
        public Watches Watches { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public Priority Priority { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Labels { get; set; }

        [JsonProperty("aggregatetimeoriginalestimate", NullValueHandling = NullValueHandling.Ignore)]
        public object Aggregatetimeoriginalestimate { get; set; }

        [JsonProperty("timeestimate", NullValueHandling = NullValueHandling.Ignore)]
        public object Timeestimate { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Versions { get; set; }

        [JsonProperty("issuelinks", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Issuelinks { get; set; }

        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public object Assignee { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status Status { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Components { get; set; }

        [JsonProperty("timeoriginalestimate", NullValueHandling = NullValueHandling.Ignore)]
        public object Timeoriginalestimate { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public object Description { get; set; }

        [JsonProperty("timetracking", NullValueHandling = NullValueHandling.Ignore)]
        public Timetracking Timetracking { get; set; }

        [JsonProperty("security", NullValueHandling = NullValueHandling.Ignore)]
        public object Security { get; set; }

        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Attachment { get; set; }

        [JsonProperty("aggregatetimeestimate", NullValueHandling = NullValueHandling.Ignore)]
        public object Aggregatetimeestimate { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public Creator Creator { get; set; }

        [JsonProperty("subtasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Subtasks { get; set; }

        [JsonProperty("reporter", NullValueHandling = NullValueHandling.Ignore)]
        public Creator Reporter { get; set; }

        [JsonProperty("aggregateprogress", NullValueHandling = NullValueHandling.Ignore)]
        public Progress Aggregateprogress { get; set; }

        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public object Environment { get; set; }

        [JsonProperty("duedate", NullValueHandling = NullValueHandling.Ignore)]
        public object Duedate { get; set; }

        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public Progress Progress { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public Comment Comment { get; set; }

        [JsonProperty("votes", NullValueHandling = NullValueHandling.Ignore)]
        public Votes Votes { get; set; }

        [JsonProperty("worklog", NullValueHandling = NullValueHandling.Ignore)]
        public Worklog Worklog { get; set; }
    }

}
