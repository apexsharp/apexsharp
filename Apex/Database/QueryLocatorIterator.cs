namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_database_querylocatoriterator.htm#apex_class_database_querylocatoriterator
    /// </summary>
    public class QueryLocatorIterator
    {
        // infrastructure
        public QueryLocatorIterator(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueryLocatorIterator));
            }
        }

        // API
        public bool hasNext()
        {
            return Self.hasNext();
        }

        public SObject next()
        {
            return Self.next();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
