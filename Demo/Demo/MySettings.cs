using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class MySettings
    {
        public bool EnableApp { get; set; }
        public List<string> Blocklists { get; set; }
        public string URL { get; set; }
        public Debugging Debug { get; set; }

        //Initlaise default settings values
        public MySettings()
        {
            EnableApp = true;
            Blocklists = new List<string>();
            URL = "https://default.com";
            Debug = new Debugging();
        }
    }

    public class Debugging
    {
        public bool EnableVerboseLogging { get; set; }
        public bool EnableTestMode { get; set; }

        //Initlaise default settings values
        public Debugging()
        {
            EnableTestMode = false;
            EnableVerboseLogging = true;
        }
    }
}
