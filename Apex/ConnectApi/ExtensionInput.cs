namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ExtensionInput
    {
        // infrastructure
        public ExtensionInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ExtensionInput));
            }
        }

        // API
        object alternativeRepresentation
        {
            get
            {
                return Self.alternativeRepresentation;
            }
            set
            {
                Self.alternativeRepresentation = value;
            }
        }

        object extensionId
        {
            get
            {
                return Self.extensionId;
            }
            set
            {
                Self.extensionId = value;
            }
        }

        object payload
        {
            get
            {
                return Self.payload;
            }
            set
            {
                Self.payload = value;
            }
        }

        object payloadVersion
        {
            get
            {
                return Self.payloadVersion;
            }
            set
            {
                Self.payloadVersion = value;
            }
        }

        public ExtensionInput()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
