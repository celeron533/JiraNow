using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    public class ParentFields
    {
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status Status { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public Priority Priority { get; set; }

        [JsonProperty("issuetype", NullValueHandling = NullValueHandling.Ignore)]
        public Issuetype Issuetype { get; set; }
    }
}
