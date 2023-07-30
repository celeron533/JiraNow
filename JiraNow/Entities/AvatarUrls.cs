using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Entities
{
    public class AvatarUrls
    {
        [JsonProperty("48x48", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The48X48 { get; set; }

        [JsonProperty("24x24", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The24X24 { get; set; }

        [JsonProperty("16x16", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The16X16 { get; set; }

        [JsonProperty("32x32", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The32X32 { get; set; }
    }
}
