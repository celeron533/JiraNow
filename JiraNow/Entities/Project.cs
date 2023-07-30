using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    public class Project
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("projectTypeKey", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectTypeKey { get; set; }

        [JsonProperty("simplified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Simplified { get; set; }

        [JsonProperty("avatarUrls", NullValueHandling = NullValueHandling.Ignore)]
        public AvatarUrls AvatarUrls { get; set; }
    }
}
