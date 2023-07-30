using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Utils
{
    public class JsonUtil
    {
        public static string Serialize(object obj, JsonSerializerSettings settings = null)
        {
            return JsonConvert.SerializeObject(obj, settings);
        }

        public static T Deserialize<T>(string jsonString, JsonSerializerSettings settings = null)
        {
            return JsonConvert.DeserializeObject<T>(jsonString, settings);
        }

        public static void SaveObjectToJsonFile(object obj, string filename, JsonSerializerSettings settings = null)
        {
            string jsonString = Serialize(obj, settings);
            File.WriteAllText(filename, jsonString);
        }

        public static T LoadObjectFromJsonFile<T>(string filename, JsonSerializerSettings settings = null)
        {
            string jsonString = File.ReadAllText(filename);
            return Deserialize<T>(jsonString, settings);
        }

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
