using JiraNow.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow
{
    internal class SettingsManager
    {
        private const string filename = "settings.json";

        public static void SaveSettings(Settings settings, string filename = filename)
        {
            JsonManager.SaveObjectToJsonFile(settings, filename);
        }

        public static Settings LoadSettings(string filename = filename)
        {
            if (!File.Exists(filename))
            {
                Settings settings = Settings.Default;
                SaveSettings(Settings.Default, filename);
                return settings;
            }
            else
            {
                return JsonManager.LoadObjectFromJsonFile<Settings>(filename);
            }
        }
    }
}
