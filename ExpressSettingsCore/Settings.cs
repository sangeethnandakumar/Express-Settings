using Newtonsoft.Json;
using System;
using System.IO;

namespace ExpressSettingsCore
{
    public static class Settings<T> where T : new()
    {
        public static T Read(SettingsConfiguration config)
        {
            try
            {
                if (!File.Exists(config.LookupDirectory + "\\" + config.Filename))
                {
                    Write(new T(), config);
                }
                string json = File.ReadAllText(config.LookupDirectory + "\\" + config.Filename);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception)
            {
                throw new Exception($"The settings file structure is changed or permission error. Make sure settings file matches with {nameof(T)}");
            }
        }

        public static void Write(T settings, SettingsConfiguration config)
        {
            try
            {
                var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(config.LookupDirectory + "\\" + config.Filename, json);
            }
            catch (Exception)
            {
                throw new Exception($"An error occured. Make sure write permissions are available on application base folder");
            }
        }
    }
}