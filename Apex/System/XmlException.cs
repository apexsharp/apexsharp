namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class XmlException : Exception
    {
        // infrastructure
        public XmlException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(XmlException));
            }
        }

        // API
        public XmlException()
        {
            Self = Implementation.Constructor();
        }

        public XmlException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public XmlException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public XmlException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
