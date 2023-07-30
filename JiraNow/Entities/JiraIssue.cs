﻿//https://app.quicktype.io/?l=csharp

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using JiraNow.Entities;
//
//    var jiraIssue = JiraIssue.FromJson(jsonString);

namespace JiraNow.Entities
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class JiraIssue
    {
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
    }

    public partial class JiraIssue
    {
        public static JiraIssue FromJson(string json) => JsonConvert.DeserializeObject<JiraIssue>(json, JiraNow.Entities.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this JiraIssue self) => JsonConvert.SerializeObject(self, JiraNow.Entities.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
