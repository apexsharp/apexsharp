namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_database_batch.htm#apex_methods_system_database_batch
    /// </summary>
    public class QueryLocator
    {
        // infrastructure
        public QueryLocator(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueryLocator));
            }
        }

        // API
        public string getQuery()
        {
            return Self.getQuery();
        }

        public QueryLocatorIterator iterator()
        {
            return Self.iterator();
        }

        public List<SObject> querymore(int num)
        {
            return Self.querymore(num);
        }
    }
}
