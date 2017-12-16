namespace Apex.Dom
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_xml_dom_document.htm#apex_classes_xml_dom_document
    /// </summary>
    public class Document
    {
        // infrastructure
        public Document(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Document));
            }
        }

        // API
        public Document()
        {
            Implementation.Constructor();
        }

        public XmlNode createRootElement(string name, string @namespace, string prefix)
        {
            return Self.createRootElement(name, @namespace, prefix);
        }

        public XmlNode getRootElement()
        {
            return Self.getRootElement();
        }

        public void load(string xml)
        {
            Self.load(xml);
        }

        public string toXmlString()
        {
            return Self.toXmlString();
        }
    }
}
