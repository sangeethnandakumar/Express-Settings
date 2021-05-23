using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExpressSettingsCore
{
    public class SettingsBuilder
    {
        private SettingsConfiguration _configuration;

        public SettingsBuilder()
        {
            _configuration = new SettingsConfiguration();
            _configuration.Filename = "settings.json";
            _configuration.LookupDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        public static SettingsBuilder Init()
        {
            return new SettingsBuilder();
        }

        public SettingsConfiguration Build() => _configuration;

        public SettingsBuilder LookupDirectory(string directory)
        {
            _configuration.LookupDirectory = directory;
            return this;
        }

        public SettingsBuilder WithName(string settingFileName)
        {
            _configuration.Filename = settingFileName;
            return this;
        }
    }
}