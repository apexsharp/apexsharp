namespace Apex.Search
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Search_SuggestionResults.htm#apex_class_Search_SuggestionResults
    /// </summary>
    public class SuggestionResults
    {
        // infrastructure
        public SuggestionResults(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SuggestionResults));
            }
        }

        // API
        public List<SuggestionResult> getSuggestionResults()
        {
            return Self.getSuggestionResults();
        }

        public bool hasMoreResults()
        {
            return Self.hasMoreResults();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
