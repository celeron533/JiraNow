using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    public class Issuerestriction
    {
        [JsonProperty("issuerestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Timetracking Issuerestrictions { get; set; }

        [JsonProperty("shouldDisplay", NullValueHandling = NullValueHandling.Ignore)]
        public bool ShouldDisplay { get; set; }
    }
}
