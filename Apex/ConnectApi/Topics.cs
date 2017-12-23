namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Topics_static_methods.htm#apex_ConnectAPI_Topics_static_methods
    /// </summary>
    public class Topics
    {
        // infrastructure
        public Topics(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Topics));
            }
        }

        // API
        public static Topic assignTopic(string communityId, string recordId, string topicId)
        {
            return Implementation.assignTopic(communityId, recordId, topicId);
        }

        public static Topic assignTopicByName(string communityId, string recordId, string topicName)
        {
            return Implementation.assignTopicByName(communityId, recordId, topicName);
        }

        public static Topic createTopic(string communityId, string name, string description)
        {
            return Implementation.createTopic(communityId, name, description);
        }

        public static TopicPage createTopicDataCategoryRules(string communityId, string dataCategoryGroup, string dataCategory, TopicNamesInput topicNames)
        {
            return Implementation.createTopicDataCategoryRules(communityId, dataCategoryGroup, dataCategory, topicNames);
        }

        public static void deleteTopic(string communityId, string topicId)
        {
            Implementation.deleteTopic(communityId, topicId);
        }

        public static ChatterGroupSummaryPage getGroupsRecentlyTalkingAboutTopic(string communityId, string topicId)
        {
            return Implementation.getGroupsRecentlyTalkingAboutTopic(communityId, topicId);
        }

        public static TopicPage getRecentlyTalkingAboutTopicsForGroup(string communityId, string groupId)
        {
            return Implementation.getRecentlyTalkingAboutTopicsForGroup(communityId, groupId);
        }

        public static TopicPage getRecentlyTalkingAboutTopicsForUser(string communityId, string userId)
        {
            return Implementation.getRecentlyTalkingAboutTopicsForUser(communityId, userId);
        }

        public static TopicPage getRelatedTopics(string communityId, string topicId)
        {
            return Implementation.getRelatedTopics(communityId, topicId);
        }

        public static Topic getTopic(string communityId, string topicId)
        {
            return Implementation.getTopic(communityId, topicId);
        }

        public static TopicPage getTopicDataCategoryRules(string communityId, string dataCategoryGroup, string dataCategory)
        {
            return Implementation.getTopicDataCategoryRules(communityId, dataCategoryGroup, dataCategory);
        }

        public static TopicPage getTopics(string communityId, string recordId)
        {
            return Implementation.getTopics(communityId, recordId);
        }

        public static TopicPage getTopics(string communityId)
        {
            return Implementation.getTopics(communityId);
        }

        public static TopicPage getTopics(string communityId, TopicSort sortParam)
        {
            return Implementation.getTopics(communityId, sortParam);
        }

        public static TopicPage getTopics(string communityId, int pageParam, int pageSize)
        {
            return Implementation.getTopics(communityId, pageParam, pageSize);
        }

        public static TopicPage getTopics(string communityId, int pageParam, int pageSize, TopicSort sortParam)
        {
            return Implementation.getTopics(communityId, pageParam, pageSize, sortParam);
        }

        public static TopicPage getTopics(string communityId, string q, TopicSort sortParam)
        {
            return Implementation.getTopics(communityId, q, sortParam);
        }

        public static TopicPage getTopics(string communityId, string q, int pageParam, int pageSize)
        {
            return Implementation.getTopics(communityId, q, pageParam, pageSize);
        }

        public static TopicPage getTopics(string communityId, string q, int pageParam, int pageSize, TopicSort sortParam)
        {
            return Implementation.getTopics(communityId, q, pageParam, pageSize, sortParam);
        }

        public static TopicPage getTopics(string communityId, string q, bool exactMatch)
        {
            return Implementation.getTopics(communityId, q, exactMatch);
        }

        public static TopicPage getTopicsOrFallBackToRenamedTopics(string communityId, string q, bool exactMatch, bool fallBackToRenamedTopics)
        {
            return Implementation.getTopicsOrFallBackToRenamedTopics(communityId, q, exactMatch, fallBackToRenamedTopics);
        }

        public static TopicSuggestionPage getTopicSuggestions(string communityId, string recordId, int maxResults)
        {
            return Implementation.getTopicSuggestions(communityId, recordId, maxResults);
        }

        public static TopicSuggestionPage getTopicSuggestions(string communityId, string recordId)
        {
            return Implementation.getTopicSuggestions(communityId, recordId);
        }

        public static TopicSuggestionPage getTopicSuggestionsForText(string communityId, string text, int maxResults)
        {
            return Implementation.getTopicSuggestionsForText(communityId, text, maxResults);
        }

        public static TopicSuggestionPage getTopicSuggestionsForText(string communityId, string text)
        {
            return Implementation.getTopicSuggestionsForText(communityId, text);
        }

        public static TopicPage getTrendingTopics(string communityId)
        {
            return Implementation.getTrendingTopics(communityId);
        }

        public static TopicPage getTrendingTopics(string communityId, int maxResults)
        {
            return Implementation.getTrendingTopics(communityId, maxResults);
        }

        public static Topic mergeTopics(string communityId, string topicId, List<string> idsToMerge)
        {
            return Implementation.mergeTopics(communityId, topicId, idsToMerge);
        }

        public static TopicPage reassignTopicDataCategoryRules(string communityId, string dataCategoryGroup, string dataCategory, TopicNamesInput topicNames)
        {
            return Implementation.reassignTopicDataCategoryRules(communityId, dataCategoryGroup, dataCategory, topicNames);
        }

        public static TopicPage reassignTopicsByName(string communityId, string recordId, TopicNamesInput topicNames)
        {
            return Implementation.reassignTopicsByName(communityId, recordId, topicNames);
        }

        public static void unassignTopic(string communityId, string recordId, string topicId)
        {
            Implementation.unassignTopic(communityId, recordId, topicId);
        }

        public static Topic updateTopic(string communityId, string topicId, TopicInput topic)
        {
            return Implementation.updateTopic(communityId, topicId, topic);
        }

        public static TopicPage updateTopicsForArticlesInDataCategory(string communityId, string dataCategoryGroup, string dataCategory, ArticleTopicAssignmentJobInput articleTopicAssignmentJob)
        {
            return Implementation.updateTopicsForArticlesInDataCategory(communityId, dataCategoryGroup, dataCategory, articleTopicAssignmentJob);
        }

        public static void setTestGetGroupsRecentlyTalkingAboutTopic(string communityId, string topicId, ChatterGroupSummaryPage result)
        {
            Implementation.setTestGetGroupsRecentlyTalkingAboutTopic(communityId, topicId, result);
        }

        public static void setTestGetRecentlyTalkingAboutTopicsForGroup(string communityId, string groupId, TopicPage result)
        {
            Implementation.setTestGetRecentlyTalkingAboutTopicsForGroup(communityId, groupId, result);
        }

        public static void setTestGetRecentlyTalkingAboutTopicsForUser(string communityId, string userId, TopicPage result)
        {
            Implementation.setTestGetRecentlyTalkingAboutTopicsForUser(communityId, userId, result);
        }

        public static void setTestGetRelatedTopics(string communityId, string topicId, TopicPage result)
        {
            Implementation.setTestGetRelatedTopics(communityId, topicId, result);
        }

        public static void setTestGetTopicSuggestions(string communityId, string recordId, int maxResults, TopicSuggestionPage result)
        {
            Implementation.setTestGetTopicSuggestions(communityId, recordId, maxResults, result);
        }

        public static void setTestGetTopicSuggestions(string communityId, string recordId, TopicSuggestionPage result)
        {
            Implementation.setTestGetTopicSuggestions(communityId, recordId, result);
        }

        public static void setTestGetTopicSuggestionsForText(string communityId, string text, int maxResults, TopicSuggestionPage result)
        {
            Implementation.setTestGetTopicSuggestionsForText(communityId, text, maxResults, result);
        }

        public static void setTestGetTopicSuggestionsForText(string communityId, string text, TopicSuggestionPage result)
        {
            Implementation.setTestGetTopicSuggestionsForText(communityId, text, result);
        }

        public static void setTestGetTrendingTopics(string communityId, TopicPage result)
        {
            Implementation.setTestGetTrendingTopics(communityId, result);
        }

        public static void setTestGetTrendingTopics(string communityId, int maxResults, TopicPage result)
        {
            Implementation.setTestGetTrendingTopics(communityId, maxResults, result);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
