using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    public class Issuetype
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri IconUrl { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("subtask", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subtask { get; set; }

        [JsonProperty("avatarId", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvatarId { get; set; }

        [JsonProperty("entityId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid EntityId { get; set; }

        [JsonProperty("hierarchyLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? HierarchyLevel { get; set; }
    }
}
