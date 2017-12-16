namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_ChatterFavorites_static_methods.htm#apex_ConnectAPI_ChatterFavorites_static_methods
    /// </summary>
    public class ChatterFavorites
    {
        // infrastructure
        public ChatterFavorites(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterFavorites));
            }
        }

        // API
        public static FeedFavorite addFavorite(string communityId, string subjectId, string searchText)
        {
            return Implementation.addFavorite(communityId, subjectId, searchText);
        }

        public static FeedFavorite addRecordFavorite(string communityId, string subjectId, string targetId)
        {
            return Implementation.addRecordFavorite(communityId, subjectId, targetId);
        }

        public static void deleteFavorite(string communityId, string subjectId, string favoriteId)
        {
            Implementation.deleteFavorite(communityId, subjectId, favoriteId);
        }

        public static FeedFavorite getFavorite(string communityId, string subjectId, string favoriteId)
        {
            return Implementation.getFavorite(communityId, subjectId, favoriteId);
        }

        public static FeedFavorites getFavorites(string communityId, string subjectId)
        {
            return Implementation.getFavorites(communityId, subjectId);
        }

        public static FeedElementPage getFeedElements(string communityId, string subjectId, string favoriteId)
        {
            return Implementation.getFeedElements(communityId, subjectId, favoriteId);
        }

        public static FeedElementPage getFeedElements(string communityId, string subjectId, string favoriteId, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedElements(communityId, subjectId, favoriteId, pageParam, pageSize, sortParam);
        }

        public static FeedElementPage getFeedElements(string communityId, string subjectId, string favoriteId, int recentCommentCount, int elementsPerBundle, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedElements(communityId, subjectId, favoriteId, recentCommentCount, elementsPerBundle, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage getFeedItems(string communityId, string subjectId, string favoriteId)
        {
            return Implementation.getFeedItems(communityId, subjectId, favoriteId);
        }

        public static FeedItemPage getFeedItems(string communityId, string subjectId, string favoriteId, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedItems(communityId, subjectId, favoriteId, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage getFeedItems(string communityId, string subjectId, string favoriteId, int recentCommentCount, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedItems(communityId, subjectId, favoriteId, recentCommentCount, pageParam, pageSize, sortParam);
        }

        public static FeedFavorite updateFavorite(string communityId, string subjectId, string favoriteId, bool updateLastViewDate)
        {
            return Implementation.updateFavorite(communityId, subjectId, favoriteId, updateLastViewDate);
        }

        public static void setTestGetFeedElements(string communityId, string subjectId, string favoriteId, FeedElementPage result)
        {
            Implementation.setTestGetFeedElements(communityId, subjectId, favoriteId, result);
        }

        public static void setTestGetFeedElements(string communityId, string subjectId, string favoriteId, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestGetFeedElements(communityId, subjectId, favoriteId, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedElements(string communityId, string subjectId, string favoriteId, int recentCommentCount, int elementsPerBundle, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestGetFeedElements(communityId, subjectId, favoriteId, recentCommentCount, elementsPerBundle, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedItems(string communityId, string subjectId, string favoriteId, FeedItemPage result)
        {
            Implementation.setTestGetFeedItems(communityId, subjectId, favoriteId, result);
        }

        public static void setTestGetFeedItems(string communityId, string subjectId, string favoriteId, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestGetFeedItems(communityId, subjectId, favoriteId, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedItems(string communityId, string subjectId, string favoriteId, int recentCommentCount, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestGetFeedItems(communityId, subjectId, favoriteId, recentCommentCount, pageParam, pageSize, sortParam, result);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
