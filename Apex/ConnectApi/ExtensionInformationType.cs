namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ExtensionInformationType
    {
        // infrastructure
        public ExtensionInformationType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ExtensionInformationType));
            }
        }

        // API
        object Lightning
        {
            get
            {
                return Self.Lightning;
            }
            set
            {
                Self.Lightning = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<ExtensionInformationType> values()
        {
            return Implementation.values();
        }
    }
}
