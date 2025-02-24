using System;
using System.IO;
using System.Xml.Linq;

namespace CloneHeroCombinedLauncher
{
    public static class AppDataSettings
    {
        private static readonly string ConfigFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CloneHeroCombinedLauncher", "config.xml");

        static AppDataSettings()
        {
            if (!File.Exists(ConfigFilePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(ConfigFilePath));
                var doc = new XDocument(new XElement("Settings",
                    new XElement("BridgePath", "undefined"),
                    new XElement("CHPath", "undefined"),
                    new XElement("NautilusPath", "undefined"),
                    new XElement("EmuPath", "undefined"),
                    new XElement("EmuWithCH", "false"),
                    new XElement("AutoRCH", "false"),
                    new XElement("AutoREmu", "false"),
                    new XElement("CHDelayForEmu", "2500"),
                    new XElement("SongsDir", "%USERPROFILE%\\Documents\\Clone Hero\\Songs\\")
                ));
                doc.Save(ConfigFilePath);
            }
        }

        public static string GetSetting(string name, string defaultValue)
        {
            var doc = XDocument.Load(ConfigFilePath);
            var element = doc.Root.Element(name);
            return element != null ? element.Value : defaultValue;
        }

        public static void SetSetting(string name, object value)
        {
            var doc = XDocument.Load(ConfigFilePath);
            var element = doc.Root.Element(name);
            if (element == null)
            {
                doc.Root.Add(new XElement(name, value.ToString()));
            }
            else
            {
                element.Value = value.ToString();
            }
            doc.Save(ConfigFilePath);
        }
    }
}
