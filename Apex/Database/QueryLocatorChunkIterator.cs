namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class QueryLocatorChunkIterator
    {
        // infrastructure
        public QueryLocatorChunkIterator(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueryLocatorChunkIterator));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public bool hasNext()
        {
            return Self.hasNext();
        }

        public List<SObject> next()
        {
            return Self.next();
        }
    }
}
