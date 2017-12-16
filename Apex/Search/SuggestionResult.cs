namespace Apex.Search
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Search_SuggestionResult.htm#apex_class_Search_SuggestionResult
    /// </summary>
    public class SuggestionResult
    {
        // infrastructure
        public SuggestionResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SuggestionResult));
            }
        }

        // API
        public SObject getSObject()
        {
            return Self.getSObject();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
