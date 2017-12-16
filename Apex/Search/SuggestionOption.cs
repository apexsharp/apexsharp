namespace Apex.Search
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Search_SuggestionOption.htm#apex_class_Search_SuggestionOption
    /// </summary>
    public class SuggestionOption
    {
        // infrastructure
        public SuggestionOption(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SuggestionOption));
            }
        }

        // API
        public void setFilter(KnowledegeSuggestionFilter knowledgeSuggestionFilter)
        {
            Self.setFilter(knowledgeSuggestionFilter);
        }

        public void setLimit(int limit)
        {
            Self.setLimit(limit);
        }

        public SuggestionOption()
        {
            Implementation.Constructor();
        }

        public void setFilter(object filter)
        {
            Self.setFilter(filter);
        }
    }
}
