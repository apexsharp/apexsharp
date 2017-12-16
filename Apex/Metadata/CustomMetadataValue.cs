namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_CustomMetadataValue.htm#apex_class_Metadata_CustomMetadataValue
    /// </summary>
    public class CustomMetadataValue
    {
        // infrastructure
        public CustomMetadataValue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CustomMetadataValue));
            }
        }

        // API
        string field
        {
            get
            {
                return Self.field;
            }
            set
            {
                Self.field = value;
            }
        }

        object value
        {
            get
            {
                return Self.value;
            }
            set
            {
                Self.value = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public CustomMetadataValue()
        {
            Implementation.Constructor();
        }
    }
}
