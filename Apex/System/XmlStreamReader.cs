namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_xml_XmlStream_reader.htm#apex_classes_xml_XmlStream_reader
    /// </summary>
    public class XmlStreamReader
    {
        // infrastructure
        public XmlStreamReader(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(XmlStreamReader));
            }
        }

        // API
        public XmlStreamReader(string xmlInput)
        {
            Implementation.Constructor(xmlInput);
        }

        public int getAttributeCount()
        {
            return Self.getAttributeCount();
        }

        public string getAttributeLocalName(int index)
        {
            return Self.getAttributeLocalName(index);
        }

        public string getAttributeNamespace(int index)
        {
            return Self.getAttributeNamespace(index);
        }

        public string getAttributePrefix(int index)
        {
            return Self.getAttributePrefix(index);
        }

        public string getAttributeType(int index)
        {
            return Self.getAttributeType(index);
        }

        public string getAttributeValue(string namespaceUri, string localName)
        {
            return Self.getAttributeValue(namespaceUri, localName);
        }

        public string getAttributeValueAt(int index)
        {
            return Self.getAttributeValueAt(index);
        }

        public XmlTag getEventType()
        {
            return Self.getEventType();
        }

        public string getLocalName()
        {
            return Self.getLocalName();
        }

        public string getLocation()
        {
            return Self.getLocation();
        }

        public string getNamespace()
        {
            return Self.getNamespace();
        }

        public int getNamespaceCount()
        {
            return Self.getNamespaceCount();
        }

        public string getNamespacePrefix(int index)
        {
            return Self.getNamespacePrefix(index);
        }

        public string getNamespaceURI(string prefix)
        {
            return Self.getNamespaceURI(prefix);
        }

        public string getNamespaceURIAt(int index)
        {
            return Self.getNamespaceURIAt(index);
        }

        public string getPIData()
        {
            return Self.getPIData();
        }

        public string getPITarget()
        {
            return Self.getPITarget();
        }

        public string getPrefix()
        {
            return Self.getPrefix();
        }

        public string getText()
        {
            return Self.getText();
        }

        public string getVersion()
        {
            return Self.getVersion();
        }

        public bool hasName()
        {
            return Self.hasName();
        }

        public bool hasNext()
        {
            return Self.hasNext();
        }

        public bool hasText()
        {
            return Self.hasText();
        }

        public bool isCharacters()
        {
            return Self.isCharacters();
        }

        public bool isEndElement()
        {
            return Self.isEndElement();
        }

        public bool isStartElement()
        {
            return Self.isStartElement();
        }

        public bool isWhiteSpace()
        {
            return Self.isWhiteSpace();
        }

        public int next()
        {
            return Self.next();
        }

        public int nextTag()
        {
            return Self.nextTag();
        }

        public void setCoalescing(bool returnAsSingleBlock)
        {
            Self.setCoalescing(returnAsSingleBlock);
        }

        public void setNamespaceAware(bool isNamespaceAware)
        {
            Self.setNamespaceAware(isNamespaceAware);
        }

        public string toString()
        {
            return Self.toString();
        }

        public bool isWhitespace()
        {
            return Self.isWhitespace();
        }
    }
}
