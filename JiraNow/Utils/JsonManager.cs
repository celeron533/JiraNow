using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow.Utils
{
    public class JsonManager
    {
        public static void SaveObjectToJsonFile(object obj, string filename, JsonSerializerSettings settings = null)
        {
            string jsonString = JsonConvert.SerializeObject(obj, settings);
            File.WriteAllText(filename, jsonString);
        }

        public static T LoadObjectFromJsonFile<T>(string filename, JsonSerializerSettings settings = null)
        {
            string jsonString = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<T>(jsonString, settings);
        }
    }
}
