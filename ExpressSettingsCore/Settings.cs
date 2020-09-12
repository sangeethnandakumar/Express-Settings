using Newtonsoft.Json;
using System;
using System.IO;

namespace ExpressSettingsCore
{
    public static class Settings<T> where T : new()
    {
        private readonly static string settingsFile = "settings.json";

        public static T Read()
        {
            try
            {
                if (!File.Exists(settingsFile))
                {
                    Write(new T());
                }
                string json = File.ReadAllText(settingsFile);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception)
            {
                throw new Exception($"The settings file structure is changed or permission error. Make sure settings file matches with {nameof(T)}");
            }
        }

        public static void Write(T settings)
        {
            try
            {
                var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(settingsFile, json);
            }
            catch (Exception)
            {
                throw new Exception($"An error occured. Make sure write permissions are available on application base folder");
            }
        }
    }
}
