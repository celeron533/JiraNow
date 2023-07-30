using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow
{
    internal class Settings
    {
        public Settings() { }
        public static Settings Default
        {
            get { return new Settings(); }
        }

        public string HostString { get; set; }
        public string CookiesString { get; set; }

    }
}
