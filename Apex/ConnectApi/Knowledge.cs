namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Knowledge_static_methods.htm#apex_ConnectAPI_Knowledge_static_methods
    /// </summary>
    public class Knowledge
    {
        // infrastructure
        public Knowledge(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Knowledge));
            }
        }

        // API
        public static KnowledgeArticleVersionCollection getTopViewedArticlesForTopic(string communityId, string topicId, int maxResults)
        {
            return Implementation.getTopViewedArticlesForTopic(communityId, topicId, maxResults);
        }

        public static KnowledgeArticleVersionCollection getTrendingArticles(string communityId, int maxResults)
        {
            return Implementation.getTrendingArticles(communityId, maxResults);
        }

        public static KnowledgeArticleVersionCollection getTrendingArticlesForTopic(string communityId, string topicId, int maxResults)
        {
            return Implementation.getTrendingArticlesForTopic(communityId, topicId, maxResults);
        }

        public static void setTestGetTrendingArticles(string communityId, int maxResults, KnowledgeArticleVersionCollection result)
        {
            Implementation.setTestGetTrendingArticles(communityId, maxResults, result);
        }

        public static void setTestGetTrendingArticlesForTopic(string communityId, string topicId, int maxResults, KnowledgeArticleVersionCollection result)
        {
            Implementation.setTestGetTrendingArticlesForTopic(communityId, topicId, maxResults, result);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
