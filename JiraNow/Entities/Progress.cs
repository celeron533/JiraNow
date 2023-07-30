using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    public class Progress
    {
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProgressProgress { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }
    }
}
