namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_Metadata.htm#apex_class_Metadata_Metadata
    /// </summary>
    public class Metadata
    {
        // infrastructure
        public Metadata(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Metadata));
            }
        }

        // API
        string fullName
        {
            get
            {
                return Self.fullName;
            }
            set
            {
                Self.fullName = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
