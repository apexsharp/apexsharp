namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_CustomMetadata.htm#apex_class_Metadata_CustomMetadata
    /// </summary>
    public class CustomMetadata
    {
        // infrastructure
        public CustomMetadata(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CustomMetadata));
            }
        }

        // API
        string description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
            }
        }

        string label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        bool protected_x
        {
            get
            {
                return Self.protected_x;
            }
            set
            {
                Self.protected_x = value;
            }
        }

        List<CustomMetadataValue> values
        {
            get
            {
                return Self.values;
            }
            set
            {
                Self.values = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public CustomMetadata()
        {
            Self = Implementation.Constructor();
        }
    }
}
