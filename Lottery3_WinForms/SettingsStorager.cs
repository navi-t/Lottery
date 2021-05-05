using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Lottery3_WinForms
{
    class SettingsStorager
    {
        private string filePath = "";

        public SettingsStorager(string filePath)
        {
            this.filePath = filePath;
            var directoryPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        public bool HasInfo()
        {
            return File.Exists(filePath);
        }

        public void SetParameter<T>(T param)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                using (var sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    xmlSerializer.Serialize(sw, param);
                    sw.Flush();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T GetParameter<T>()
            where T : new()
        {
            try
            {
                if (!HasInfo())
                {
                    return new T();
                }
                var xmlSerializer = new XmlSerializer(typeof(T));
                var xmlSettings = new XmlReaderSettings()
                {
                    CheckCharacters = false,
                };
                using (var sr = new StreamReader(filePath, Encoding.UTF8))
                using (var xmlReader = XmlReader.Create(sr, xmlSettings))
                {
                    return (T)xmlSerializer.Deserialize(xmlReader);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
