using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    public class Votes
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("votes", NullValueHandling = NullValueHandling.Ignore)]
        public long? VotesVotes { get; set; }

        [JsonProperty("hasVoted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasVoted { get; set; }
    }
}
