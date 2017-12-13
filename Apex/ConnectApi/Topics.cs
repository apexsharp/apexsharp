using Apex.System;

namespace Apex.ConnectApi
{
    public class Topics
    {
        public static Topic assignTopic(string communityId, string recordId, string topicId)
        {
            throw new global::System.NotImplementedException("Topics.AssignTopic");
        }

        public static Topic assignTopicByName(string communityId, string recordId, string topicName)
        {
            throw new global::System.NotImplementedException("Topics.AssignTopicByName");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("Topics.Clone");
        }

        public static Topic createTopic(string communityId, string name, string description)
        {
            throw new global::System.NotImplementedException("Topics.CreateTopic");
        }

        public static void deleteTopic(string communityId, string topicId)
        {
            throw new global::System.NotImplementedException("Topics.DeleteTopic");
        }

        //public static ChatterGroupSummaryPage GetGroupsRecentlyTalkingAboutTopic(string communityId,string topicId){throw new global::System.NotImplementedException("Topics.GetGroupsRecentlyTalkingAboutTopic");}
        public static TopicPage getRecentlyTalkingAboutTopicsForGroup(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("Topics.GetRecentlyTalkingAboutTopicsForGroup");
        }

        public static TopicPage getRecentlyTalkingAboutTopicsForUser(string communityId, string userId)
        {
            throw new global::System.NotImplementedException("Topics.GetRecentlyTalkingAboutTopicsForUser");
        }

        public static TopicPage getRelatedTopics(string communityId, string topicId)
        {
            throw new global::System.NotImplementedException("Topics.GetRelatedTopics");
        }

        public static Topic getTopic(string communityId, string topicId)
        {
            throw new global::System.NotImplementedException("Topics.GetTopic");
        }

        public static TopicSuggestionPage getTopicSuggestions(string communityId, string recordId)
        {
            throw new global::System.NotImplementedException("Topics.GetTopicSuggestions");
        }

        public static TopicSuggestionPage getTopicSuggestions(string communityId, string recordId, int maxResults)
        {
            throw new global::System.NotImplementedException("Topics.GetTopicSuggestions");
        }

        public static TopicSuggestionPage getTopicSuggestionsForText(string communityId, string text)
        {
            throw new global::System.NotImplementedException("Topics.GetTopicSuggestionsForText");
        }

        public static TopicSuggestionPage getTopicSuggestionsForText(string communityId, string text, int maxResults)
        {
            throw new global::System.NotImplementedException("Topics.GetTopicSuggestionsForText");
        }

        public static TopicPage getTopics(string communityId)
        {
            throw new global::System.NotImplementedException("Topics.GetTopics");
        }

        public static TopicPage getTopics(string communityId, TopicSort sortParam)
        {
            throw new global::System.NotImplementedException("Topics.GetTopics");
        }

        public static TopicPage getTopics(string communityId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("Topics.GetTopics");
        }

        public static TopicPage getTopics(string communityId, int pageParam, int pageSize, TopicSort sortParam)
        {
            throw new global::System.NotImplementedException("Topics.GetTopics");
        }

        public static TopicPage getTopics(string communityId, string q, bool exactMatch)
        {
            throw new global::System.NotImplementedException("Topics.GetTopics");
        }

        public static TopicPage getTopics(string communityId, string q, TopicSort sortParam)
        {
            throw new global::System.NotImplementedException("Topics.GetTopics");
        }

        public static TopicPage getTopics(string communityId, string q, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("Topics.GetTopics");
        }

        public static TopicPage getTopics(string communityId, string q, int pageParam, int pageSize,
            TopicSort sortParam)
        {
            throw new global::System.NotImplementedException("Topics.GetTopics");
        }

        public static TopicPage getTopics(string communityId, string recordId)
        {
            throw new global::System.NotImplementedException("Topics.GetTopics");
        }

        public static TopicPage getTopicsOrFallBackToRenamedTopics(string communityId, string q, bool exactMatch,
            bool fallBackToRenamedTopics)
        {
            throw new global::System.NotImplementedException("Topics.GetTopicsOrFallBackToRenamedTopics");
        }

        public static TopicPage getTrendingTopics(string communityId)
        {
            throw new global::System.NotImplementedException("Topics.GetTrendingTopics");
        }

        public static TopicPage getTrendingTopics(string communityId, int maxResults)
        {
            throw new global::System.NotImplementedException("Topics.GetTrendingTopics");
        }

        public static Topic mergeTopics(string communityId, string topicId, List<string> idsToMerge)
        {
            throw new global::System.NotImplementedException("Topics.MergeTopics");
        }

        public static TopicPage reassignTopicsByName(string communityId, string recordId, TopicNamesInput topicNames)
        {
            throw new global::System.NotImplementedException("Topics.ReassignTopicsByName");
        }

        //public static void SetTestGetGroupsRecentlyTalkingAboutTopic(string communityId,string topicId,ChatterGroupSummaryPage result){throw new global::System.NotImplementedException("Topics.SetTestGetGroupsRecentlyTalkingAboutTopic");}
        public static void setTestGetRecentlyTalkingAboutTopicsForGroup(string communityId, string groupId,
            TopicPage result)
        {
            throw new global::System.NotImplementedException("Topics.SetTestGetRecentlyTalkingAboutTopicsForGroup");
        }

        public static void setTestGetRecentlyTalkingAboutTopicsForUser(string communityId, string userId,
            TopicPage result)
        {
            throw new global::System.NotImplementedException("Topics.SetTestGetRecentlyTalkingAboutTopicsForUser");
        }

        public static void setTestGetRelatedTopics(string communityId, string topicId, TopicPage result)
        {
            throw new global::System.NotImplementedException("Topics.SetTestGetRelatedTopics");
        }

        public static void setTestGetTopicSuggestions(string communityId, string recordId, TopicSuggestionPage result)
        {
            throw new global::System.NotImplementedException("Topics.SetTestGetTopicSuggestions");
        }

        public static void setTestGetTopicSuggestions(string communityId, string recordId, int maxResults,
            TopicSuggestionPage result)
        {
            throw new global::System.NotImplementedException("Topics.SetTestGetTopicSuggestions");
        }

        public static void setTestGetTopicSuggestionsForText(string communityId, string text,
            TopicSuggestionPage result)
        {
            throw new global::System.NotImplementedException("Topics.SetTestGetTopicSuggestionsForText");
        }

        public static void setTestGetTopicSuggestionsForText(string communityId, string text, int maxResults,
            TopicSuggestionPage result)
        {
            throw new global::System.NotImplementedException("Topics.SetTestGetTopicSuggestionsForText");
        }

        public static void setTestGetTrendingTopics(string communityId, TopicPage result)
        {
            throw new global::System.NotImplementedException("Topics.SetTestGetTrendingTopics");
        }

        public static void setTestGetTrendingTopics(string communityId, int maxResults, TopicPage result)
        {
            throw new global::System.NotImplementedException("Topics.SetTestGetTrendingTopics");
        }

        public static void unassignTopic(string communityId, string recordId, string topicId)
        {
            throw new global::System.NotImplementedException("Topics.UnassignTopic");
        }

        public static Topic updateTopic(string communityId, string topicId, TopicInput topic)
        {
            throw new global::System.NotImplementedException("Topics.UpdateTopic");
        }
    }
}