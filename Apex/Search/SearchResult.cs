namespace Apex.Search
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Search_SearchResult.htm#apex_class_Search_SearchResult
    /// </summary>
    public class SearchResult
    {
        // infrastructure
        public SearchResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SearchResult));
            }
        }

        // API
        public SObject getSObject()
        {
            return Self.getSObject();
        }

        public string getSnippet(string fieldName)
        {
            return Self.getSnippet(fieldName);
        }

        public string getSnippet()
        {
            return Self.getSnippet();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
