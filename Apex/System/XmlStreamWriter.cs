namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_xml_XmlStream_writer.htm#apex_classes_XmlStream_writer
    /// </summary>
    public class XmlStreamWriter
    {
        // infrastructure
        public XmlStreamWriter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(XmlStreamWriter));
            }
        }

        // API
        public XmlStreamWriter()
        {
            Implementation.Constructor();
        }

        public void close()
        {
            Self.close();
        }

        public string getXmlString()
        {
            return Self.getXmlString();
        }

        public void setDefaultNamespace(string uri)
        {
            Self.setDefaultNamespace(uri);
        }

        public void writeAttribute(string prefix, string namespaceUri, string localName, string value)
        {
            Self.writeAttribute(prefix, namespaceUri, localName, value);
        }

        public void writeCData(string data)
        {
            Self.writeCData(data);
        }

        public void writeCharacters(string text)
        {
            Self.writeCharacters(text);
        }

        public void writeComment(string comment)
        {
            Self.writeComment(comment);
        }

        public void writeDefaultNamespace(string namespaceUri)
        {
            Self.writeDefaultNamespace(namespaceUri);
        }

        public void writeEmptyElement(string prefix, string localName, string namespaceUri)
        {
            Self.writeEmptyElement(prefix, localName, namespaceUri);
        }

        public void writeEndDocument()
        {
            Self.writeEndDocument();
        }

        public void writeEndElement()
        {
            Self.writeEndElement();
        }

        public void writeNamespace(string prefix, string namespaceUri)
        {
            Self.writeNamespace(prefix, namespaceUri);
        }

        public void writeProcessingInstruction(string target, string data)
        {
            Self.writeProcessingInstruction(target, data);
        }

        public void writeStartDocument(string encoding, string version)
        {
            Self.writeStartDocument(encoding, version);
        }

        public void writeStartElement(string prefix, string localName, string namespaceUri)
        {
            Self.writeStartElement(prefix, localName, namespaceUri);
        }
    }
}
