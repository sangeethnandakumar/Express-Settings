using ExpressSettings;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        private SettingsConfiguration config;

        public Form1()
        {
            InitializeComponent();
            config = new SettingsBuilder().Build();
        }

        private void readSettings_Click(object sender, EventArgs e)
        {
            var settings = Settings<MySettings>.Read(config);
            MessageBox.Show(settings.URL);
        }

        private void writeSettings_Click(object sender, EventArgs e)
        {
            //Your settings
            var settings = new MySettings
            {
                EnableApp = true,
                Blocklists = new List<string> { "List A", "List B", "List C", "List D" },
                URL = url.Text,
                Debug = new Debugging
                {
                    EnableTestMode = false,
                    EnableVerboseLogging = true
                }
            };

            //Write settings
            Settings<MySettings>.Write(settings, config);
        }
    }
}