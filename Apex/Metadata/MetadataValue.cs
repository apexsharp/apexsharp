namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_MetadataValue.htm#apex_class_Metadata_MetadataValue
    /// </summary>
    public class MetadataValue
    {
        // infrastructure
        public MetadataValue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MetadataValue));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}
