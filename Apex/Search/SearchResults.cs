namespace Apex.Search
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Search_SearchResults.htm#apex_class_Search_SearchResults
    /// </summary>
    public class SearchResults
    {
        // infrastructure
        public SearchResults(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SearchResults));
            }
        }

        // API
        public List<SearchResult> get(string sObjectType)
        {
            return Self.get(sObjectType);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
