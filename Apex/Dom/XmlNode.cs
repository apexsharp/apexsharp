namespace Apex.Dom
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_xml_dom_xmlnode.htm#apex_classes_xml_dom_xmlnode
    /// </summary>
    public class XmlNode
    {
        // infrastructure
        public XmlNode(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(XmlNode));
            }
        }

        // API
        public XmlNode addChildElement(string name, string @namespace, string prefix)
        {
            return Self.addChildElement(name, @namespace, prefix);
        }

        public XmlNode addCommentNode(string text)
        {
            return Self.addCommentNode(text);
        }

        public XmlNode addTextNode(string text)
        {
            return Self.addTextNode(text);
        }

        public string getAttribute(string key, string keyNamespace)
        {
            return Self.getAttribute(key, keyNamespace);
        }

        public int getAttributeCount()
        {
            return Self.getAttributeCount();
        }

        public string getAttributeKeyAt(int index)
        {
            return Self.getAttributeKeyAt(index);
        }

        public string getAttributeKeyNsAt(int index)
        {
            return Self.getAttributeKeyNsAt(index);
        }

        public string getAttributeValue(string key, string keyNamespace)
        {
            return Self.getAttributeValue(key, keyNamespace);
        }

        public string getAttributeValueNs(string key, string keyNamespace)
        {
            return Self.getAttributeValueNs(key, keyNamespace);
        }

        public XmlNode getChildElement(string name, string @namespace)
        {
            return Self.getChildElement(name, @namespace);
        }

        public XmlNode[] getChildElements()
        {
            return Self.getChildElements();
        }

        public XmlNode[] getChildren()
        {
            return Self.getChildren();
        }

        public string getName()
        {
            return Self.getName();
        }

        public string getNamespace()
        {
            return Self.getNamespace();
        }

        public string getNamespaceFor(string prefix)
        {
            return Self.getNamespaceFor(prefix);
        }

        public XmlNodeType getNodeType()
        {
            return Self.getNodeType();
        }

        public XmlNode getParent()
        {
            return Self.getParent();
        }

        public string getPrefixFor(string @namespace)
        {
            return Self.getPrefixFor(@namespace);
        }

        public string getText()
        {
            return Self.getText();
        }

        public XmlNode insertBefore(XmlNode newChild, XmlNode refChild)
        {
            return Self.insertBefore(newChild, refChild);
        }

        public bool removeAttribute(string key, string keyNamespace)
        {
            return Self.removeAttribute(key, keyNamespace);
        }

        public bool removeChild(XmlNode childNode)
        {
            return Self.removeChild(childNode);
        }

        public void setAttribute(string key, string value)
        {
            Self.setAttribute(key, value);
        }

        public void setAttributeNs(string key, string value, string keyNamespace, string valueNamespace)
        {
            Self.setAttributeNs(key, value, keyNamespace, valueNamespace);
        }

        public void setNamespace(string prefix, string @namespace)
        {
            Self.setNamespace(prefix, @namespace);
        }

        public XmlNode insertBefore(object newChild, object refChild)
        {
            return Self.insertBefore(newChild, refChild);
        }

        public bool removeChild(object child)
        {
            return Self.removeChild(child);
        }
    }
}
