namespace Apex.Search
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Search_QuestionSuggestionFilter.htm#apex_class_Search_QuestionSuggestionFilter
    /// </summary>
    public class QuestionSuggestionFilter
    {
        // infrastructure
        public QuestionSuggestionFilter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuestionSuggestionFilter));
            }
        }

        // API
        public void addGroupId(string groupId)
        {
            Self.addGroupId(groupId);
        }

        public void addNetworkId(string networkId)
        {
            Self.addNetworkId(networkId);
        }

        public void addUserId(string userId)
        {
            Self.addUserId(userId);
        }

        public void setGroupIds(List<string> groupIds)
        {
            Self.setGroupIds(groupIds);
        }

        public void setNetworkIds(List<string> networkIds)
        {
            Self.setNetworkIds(networkIds);
        }

        public void setTopicId(string topicId)
        {
            Self.setTopicId(topicId);
        }

        public void setUserIds(List<string> userIds)
        {
            Self.setUserIds(userIds);
        }

        public QuestionSuggestionFilter()
        {
            Implementation.Constructor();
        }
    }
}
