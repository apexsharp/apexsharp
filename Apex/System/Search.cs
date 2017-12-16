namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.Search;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_search.htm#apex_methods_system_search
    /// </summary>
    public class Search
    {
        // infrastructure
        public Search(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Search));
            }
        }

        // API
        public static SearchResults find(string searchQuery)
        {
            return Implementation.find(searchQuery);
        }

        public static SObject[] query(string query)
        {
            return Implementation.query(query);
        }

        public static SuggestionResults suggest(string searchQuery, string sObjectType, SuggestionOption suggestions)
        {
            return Implementation.suggest(searchQuery, sObjectType, suggestions);
        }
    }
}
