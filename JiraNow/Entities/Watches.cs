using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    public class Watches
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("watchCount", NullValueHandling = NullValueHandling.Ignore)]
        public long WatchCount { get; set; }

        [JsonProperty("isWatching", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsWatching { get; set; }
    }
}
