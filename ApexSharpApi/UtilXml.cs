using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ApexSharpApi
{
    class UtilXml
    {
        public static string FormatXml(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch (Exception)
            {
                return xml;
            }
        }

        public static string SerializeToXML<T>(T obj)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
            using (var stringWriter = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(stringWriter))
                {
                    xsSubmit.Serialize(writer, obj);
                    return stringWriter.ToString();
                }
            }
        }

        public static T DeSerilizeFromXML<T>(string xml)
        {
            XmlSerializer x = new XmlSerializer(typeof(T));
            var myTest = (T)x.Deserialize(new StringReader(xml));
            return myTest;
        }
    }
}