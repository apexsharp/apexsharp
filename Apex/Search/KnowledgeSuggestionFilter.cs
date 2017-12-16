namespace Apex.Search
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Search_KnowledgeSuggestionFilter.htm#apex_class_Search_KnowledgeSuggestionFilter
    /// </summary>
    public class KnowledgeSuggestionFilter
    {
        // infrastructure
        public KnowledgeSuggestionFilter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(KnowledgeSuggestionFilter));
            }
        }

        // API
        public void addArticleType(string articleType)
        {
            Self.addArticleType(articleType);
        }

        public void addDataCategory(string dataCategoryGroupName, string dataCategoryName)
        {
            Self.addDataCategory(dataCategoryGroupName, dataCategoryName);
        }

        public void addTopic(string topic)
        {
            Self.addTopic(topic);
        }

        public void setChannel(string channelName)
        {
            Self.setChannel(channelName);
        }

        public void setDataCategories(Map<string, string> dataCategoryFilters)
        {
            Self.setDataCategories(dataCategoryFilters);
        }

        public void setLanguage(string localeCode)
        {
            Self.setLanguage(localeCode);
        }

        public void setPublishStatus(string publishStatus)
        {
            Self.setPublishStatus(publishStatus);
        }

        public void setValidationStatus(string validationStatus)
        {
            Self.setValidationStatus(validationStatus);
        }

        public KnowledgeSuggestionFilter()
        {
            Implementation.Constructor();
        }
    }
}
