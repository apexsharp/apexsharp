namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_ReadContext.htm#apex_class_DataSource_ReadContext
    /// </summary>
    public class ReadContext
    {
        // infrastructure
        public ReadContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReadContext));
            }
        }

        // API
        int maxResults
        {
            get
            {
                return Self.maxResults;
            }
            set
            {
                Self.maxResults = value;
            }
        }

        List<Table> metadata
        {
            get
            {
                return Self.metadata;
            }
            set
            {
                Self.metadata = value;
            }
        }

        int offset
        {
            get
            {
                return Self.offset;
            }
            set
            {
                Self.offset = value;
            }
        }
    }
}
