﻿//https://app.quicktype.io/?l=csharp

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using JiraNow.Entities;
//
//    var jiraSearchResult = JiraSearchResult.FromJson(jsonString);

namespace JiraNow.Entities
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class JiraSearchResult
    {
        [JsonProperty("expand")]
        public string Expand { get; set; }

        [JsonProperty("startAt")]
        public long StartAt { get; set; }

        [JsonProperty("maxResults")]
        public long MaxResults { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("issues")]
        public List<Issue> Issues { get; set; }
    }

    public partial class Issue
    {
        [JsonProperty("expand")]
        public string Expand { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("fields")]
        public IssueFields Fields { get; set; }
    }

    public partial class IssueFields
    {
        [JsonProperty("statuscategorychangedate")]
        public string Statuscategorychangedate { get; set; }

        [JsonProperty("issuetype")]
        public Issuetype Issuetype { get; set; }

        [JsonProperty("parent")]
        public Parent Parent { get; set; }

        [JsonProperty("timespent")]
        public object Timespent { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("fixVersions")]
        public List<object> FixVersions { get; set; }

        [JsonProperty("aggregatetimespent")]
        public object Aggregatetimespent { get; set; }

        [JsonProperty("resolution")]
        public object Resolution { get; set; }

        [JsonProperty("resolutiondate")]
        public object Resolutiondate { get; set; }

        [JsonProperty("workratio")]
        public long Workratio { get; set; }

        [JsonProperty("watches")]
        public Watches Watches { get; set; }

        [JsonProperty("lastViewed")]
        public string LastViewed { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("priority")]
        public Priority Priority { get; set; }

        [JsonProperty("labels")]
        public List<object> Labels { get; set; }

        [JsonProperty("aggregatetimeoriginalestimate")]
        public object Aggregatetimeoriginalestimate { get; set; }

        [JsonProperty("timeestimate")]
        public object Timeestimate { get; set; }

        [JsonProperty("versions")]
        public List<object> Versions { get; set; }

        [JsonProperty("issuelinks")]
        public List<object> Issuelinks { get; set; }

        [JsonProperty("assignee")]
        public Creator Assignee { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("components")]
        public List<object> Components { get; set; }

        [JsonProperty("timeoriginalestimate")]
        public object Timeoriginalestimate { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("security")]
        public object Security { get; set; }

        [JsonProperty("aggregatetimeestimate")]
        public object Aggregatetimeestimate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("creator")]
        public Creator Creator { get; set; }

        [JsonProperty("subtasks")]
        public List<Parent> Subtasks { get; set; }

        [JsonProperty("reporter")]
        public Creator Reporter { get; set; }

        [JsonProperty("aggregateprogress")]
        public Progress Aggregateprogress { get; set; }

        [JsonProperty("environment")]
        public object Environment { get; set; }

        [JsonProperty("duedate")]
        public object Duedate { get; set; }

        [JsonProperty("progress")]
        public Progress Progress { get; set; }

        [JsonProperty("votes")]
        public Votes Votes { get; set; }
    }



    public partial class Parent
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("fields")]
        public ParentFields Fields { get; set; }
    }

    public partial class ParentFields
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("priority")]
        public Priority Priority { get; set; }

        [JsonProperty("issuetype")]
        public Issuetype Issuetype { get; set; }
    }


    public partial class JiraSearchResult
    {
        public static JiraSearchResult FromJson(string json) => JsonConvert.DeserializeObject<JiraSearchResult>(json, JiraNow.Entities.Converter.Settings);
    }

    //public static class Serialize
    //{
    //    public static string ToJson(this JiraSearchResult self) => JsonConvert.SerializeObject(self, JiraNow.Entities.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}


}