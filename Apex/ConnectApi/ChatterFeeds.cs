using Apex.System;

namespace Apex.ConnectApi
{
    public class ChatterFeeds
    {
        public object clone()
        {
            throw new global::System.NotImplementedException("ChatterFeeds.Clone");
        }

        public static ChatterStream createStream(string communityId, ChatterStreamInput streamInput)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.CreateStream");
        }

        public static void deleteComment(string communityId, string commentId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.DeleteComment");
        }

        public static void deleteFeedElement(string communityId, string feedElementId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.DeleteFeedElement");
        }

        public static void deleteFeedItem(string communityId, string feedItemId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.DeleteFeedItem");
        }

        public static void deleteLike(string communityId, string likeId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.DeleteLike");
        }

        public static void deleteStream(string communityId, string streamId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.DeleteStream");
        }

        public static Comment getComment(string communityId, string commentId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetComment");
        }

        public static CommentPage getCommentsForFeedElement(string communityId, string feedElementId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetCommentsForFeedElement");
        }

        public static CommentPage getCommentsForFeedElement(string communityId, string feedElementId, string pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetCommentsForFeedElement");
        }

        public static CommentPage getCommentsForFeedItem(string communityId, string feedItemId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetCommentsForFeedItem");
        }

        public static CommentPage getCommentsForFeedItem(string communityId, string feedItemId, string pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetCommentsForFeedItem");
        }

        public static Feed getFeed(string communityId, FeedType feedType)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeed");
        }

        public static Feed getFeed(string communityId, FeedType feedType, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeed");
        }

        public static Feed getFeed(string communityId, FeedType feedType, string subjectId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeed");
        }

        public static Feed getFeed(string communityId, FeedType feedType, string subjectId, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeed");
        }

        public static FeedDirectory getFeedDirectory(string communityId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedDirectory");
        }

        public static FeedElement getFeedElement(string communityId, string feedElementId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElement");
        }

        public static FeedElement getFeedElement(string communityId, string feedElementId, int recentCommentCount,
            int elementsPerBundle)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElement");
        }

        public static List<BatchResult> getFeedElementBatch(string communityId, List<string> feedElementIds)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementBatch");
        }

        public static PollCapability getFeedElementPoll(string communityId, string feedElementId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementPoll");
        }

        public static FeedElementPage getFeedElementsFromBundle(string communityId, string feedElementId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromBundle");
        }

        public static FeedElementPage getFeedElementsFromBundle(string communityId, string feedElementId,
            string pageParam, int pageSize, int elementsPerBundle, int recentCommentCount)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromBundle");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            FeedFilter filter)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string pageParam,
            int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            bool showInternalOnly)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            FeedFilter filter)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize,
            FeedSortOrder sortParam, bool showInternalOnly)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize,
            FeedSortOrder sortParam, bool showInternalOnly, FeedFilter filter)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFeed");
        }

        public static FeedElementPage getFeedElementsFromFilterFeed(string communityId, string subjectId,
            string keyPrefix)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFilterFeed");
        }

        public static FeedElementPage getFeedElementsFromFilterFeed(string communityId, string subjectId,
            string keyPrefix, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam,
            int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFilterFeed");
        }

        public static FeedElementPage getFeedElementsFromFilterFeed(string communityId, string subjectId,
            string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFilterFeed");
        }

        public static FeedElementPage getFeedElementsFromFilterFeedUpdatedSince(string communityId, string subjectId,
            string keyPrefix, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam,
            int pageSize, string updatedSince)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsFromFilterFeedUpdatedSince");
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsUpdatedSince");
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince,
            FeedFilter filter)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsUpdatedSince");
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType,
            string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize,
            string updatedSince)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsUpdatedSince");
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType,
            string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize,
            string updatedSince, bool showInternalOnly)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsUpdatedSince");
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType,
            string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam,
            int pageSize, string updatedSince, bool showInternalOnly)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsUpdatedSince");
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType,
            string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam,
            int pageSize, string updatedSince, bool showInternalOnly, FeedFilter filter)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsUpdatedSince");
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType,
            string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam,
            int pageSize, string updatedSince, FeedFilter filter)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedElementsUpdatedSince");
        }

        public static FeedItem getFeedItem(string communityId, string feedItemId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItem");
        }

        public static List<BatchResult> getFeedItemBatch(string communityId, List<string> feedItemIds)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemBatch");
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFeed");
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, int recentCommentCount,
            FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFeed");
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string pageParam,
            int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFeed");
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFeed");
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFeed");
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            bool showInternalOnly)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFeed");
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId,
            string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFeed");
        }

        public static FeedItemPage getFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFilterFeed");
        }

        public static FeedItemPage getFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFilterFeed");
        }

        public static FeedItemPage getFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix,
            string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFilterFeed");
        }

        public static FeedItemPage getFeedItemsFromFilterFeedUpdatedSince(string communityId, string subjectId,
            string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize,
            string updatedSince)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsFromFilterFeedUpdatedSince");
        }

        public static FeedItemPage getFeedItemsUpdatedSince(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsUpdatedSince");
        }

        public static FeedItemPage getFeedItemsUpdatedSince(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsUpdatedSince");
        }

        public static FeedItemPage getFeedItemsUpdatedSince(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince,
            bool showInternalOnly)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedItemsUpdatedSince");
        }

        public static FeedPoll getFeedPoll(string communityId, string feedItemId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFeedPoll");
        }

        public static Feed getFilterFeed(string communityId, string subjectId, string keyPrefix)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFilterFeed");
        }

        public static Feed getFilterFeed(string communityId, string subjectId, string keyPrefix,
            FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFilterFeed");
        }

        public static FeedDirectory getFilterFeedDirectory(string communityId, string subjectId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetFilterFeedDirectory");
        }

        public static ChatterLike getLike(string communityId, string likeId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetLike");
        }

        public static ChatterLikePage getLikesForComment(string communityId, string commentId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetLikesForComment");
        }

        public static ChatterLikePage getLikesForComment(string communityId, string commentId, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetLikesForComment");
        }

        public static ChatterLikePage getLikesForFeedElement(string communityId, string feedElementId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetLikesForFeedElement");
        }

        public static ChatterLikePage getLikesForFeedElement(string communityId, string feedElementId, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetLikesForFeedElement");
        }

        public static ChatterLikePage getLikesForFeedItem(string communityId, string feedItemId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetLikesForFeedItem");
        }

        public static ChatterLikePage getLikesForFeedItem(string communityId, string feedItemId, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetLikesForFeedItem");
        }

        public static RelatedFeedPosts getRelatedPosts(string communityId, string feedElementId,
            RelatedFeedPostType filter, int maxResults)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetRelatedPosts");
        }

        public static ChatterStream getStream(string communityId, string streamId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetStream");
        }

        public static ChatterStreamPage getStreams(string communityId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetStreams");
        }

        public static ChatterStreamPage getStreams(string communityId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetStreams");
        }

        public static SupportedEmojis getSupportedEmojis()
        {
            throw new global::System.NotImplementedException("ChatterFeeds.GetSupportedEmojis");
        }

        public static FeedEntityIsEditable isCommentEditableByMe(string communityId, string commentId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.IsCommentEditableByMe");
        }

        public static FeedEntityIsEditable isFeedElementEditableByMe(string communityId, string feedElementId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.IsFeedElementEditableByMe");
        }

        public static FeedModifiedInfo isModified(string communityId, FeedType feedType, string subjectId, string since)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.IsModified");
        }

        public static ChatterLike likeComment(string communityId, string commentId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.LikeComment");
        }

        public static ChatterLike likeFeedElement(string communityId, string feedElementId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.LikeFeedElement");
        }

        public static ChatterLike likeFeedItem(string communityId, string feedItemId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.LikeFeedItem");
        }

        public static Comment postComment(string communityId, string feedItemId, CommentInput comment,
            BinaryInput feedItemFileUpload)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostComment");
        }

        public static Comment postComment(string communityId, string feedItemId, string text)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostComment");
        }

        public static Comment postCommentToFeedElement(string communityId, string feedElementId, CommentInput comment,
            BinaryInput feedElementFileUpload)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostCommentToFeedElement");
        }

        public static Comment postCommentToFeedElement(string communityId, string feedElementId, string text)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostCommentToFeedElement");
        }

        public static FeedElement postFeedElement(string communityId, FeedElementInput feedElement)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostFeedElement");
        }

        public static FeedElement postFeedElement(string communityId, FeedElementInput feedElement,
            BinaryInput feedElementFileUpload)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostFeedElement");
        }

        public static FeedElement postFeedElement(string communityId, string subjectId, FeedElementType feedElementType,
            string text)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostFeedElement");
        }

        public static List<BatchResult> postFeedElementBatch(string communityId, List<BatchInput> feedElements)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostFeedElementBatch");
        }

        public static FeedItem postFeedItem(string communityId, FeedType feedType, string subjectId,
            FeedItemInput feedItem, BinaryInput feedItemFileUpload)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostFeedItem");
        }

        public static FeedItem postFeedItem(string communityId, FeedType feedType, string subjectId, string text)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.PostFeedItem");
        }

        public static FeedElementPage searchFeedElements(string communityId, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElements");
        }

        public static FeedElementPage searchFeedElements(string communityId, string q, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElements");
        }

        public static FeedElementPage searchFeedElements(string communityId, string q, int recentCommentCount,
            string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElements");
        }

        public static FeedElementPage searchFeedElements(string communityId, string q, string pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElements");
        }

        public static FeedElementPage searchFeedElements(string communityId, string q, string pageParam, int pageSize,
            FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElements");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, FeedFilter filter)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string pageParam,
            int pageSize, FeedSortOrder sortParam, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, bool showInternalOnly)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, bool showInternalOnly, FeedFilter filter)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, FeedFilter filter)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFeed");
        }

        public static FeedElementPage searchFeedElementsInFilterFeed(string communityId, string subjectId,
            string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize,
            FeedSortOrder sortParam, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFilterFeed");
        }

        public static FeedElementPage searchFeedElementsInFilterFeed(string communityId, string subjectId,
            string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFilterFeed");
        }

        public static FeedElementPage searchFeedElementsInFilterFeed(string communityId, string subjectId,
            string keyPrefix, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedElementsInFilterFeed");
        }

        public static FeedItemPage searchFeedItems(string communityId, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItems");
        }

        public static FeedItemPage searchFeedItems(string communityId, string q, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItems");
        }

        public static FeedItemPage searchFeedItems(string communityId, string q, int recentCommentCount,
            string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItems");
        }

        public static FeedItemPage searchFeedItems(string communityId, string q, string pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItems");
        }

        public static FeedItemPage searchFeedItems(string communityId, string q, string pageParam, int pageSize,
            FeedSortOrder sortParam)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItems");
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, int recentCommentCount,
            FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFeed");
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string pageParam,
            int pageSize, FeedSortOrder sortParam, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFeed");
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFeed");
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFeed");
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, bool showInternalOnly)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFeed");
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId,
            string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFeed");
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId,
            string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFeed");
        }

        public static FeedItemPage searchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFilterFeed");
        }

        public static FeedItemPage searchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix,
            string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFilterFeed");
        }

        public static FeedItemPage searchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix,
            string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchFeedItemsInFilterFeed");
        }

        public static ChatterStreamPage searchStreams(string communityId, string q)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchStreams");
        }

        public static ChatterStreamPage searchStreams(string communityId, string q, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SearchStreams");
        }

        public static StatusCapability setFeedCommentStatus(string communityId, string commentId,
            StatusCapabilityInput status)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetFeedCommentStatus");
        }

        public static StatusCapability setFeedEntityStatus(string communityId, string feedElementId,
            StatusCapabilityInput status)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetFeedEntityStatus");
        }

        public static MuteCapability setIsMutedByMe(string communityId, string feedElementId, bool isMutedByMe)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetIsMutedByMe");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, int recentCommentCount,
            FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, int recentCommentCount,
            FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedFilter filter,
            FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string pageParam,
            int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            bool showInternalOnly, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            FeedFilter filter, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize,
            FeedSortOrder sortParam, bool showInternalOnly, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize,
            FeedSortOrder sortParam, bool showInternalOnly, FeedFilter filter, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId,
            string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFeed");
        }

        public static void setTestGetFeedElementsFromFilterFeed(string communityId, string subjectId, string keyPrefix,
            FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFilterFeed");
        }

        public static void setTestGetFeedElementsFromFilterFeed(string communityId, string subjectId, string keyPrefix,
            int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize,
            FeedSortOrder sortParam, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFilterFeed");
        }

        public static void setTestGetFeedElementsFromFilterFeed(string communityId, string subjectId, string keyPrefix,
            string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsFromFilterFeed");
        }

        public static void setTestGetFeedElementsFromFilterFeedUpdatedSince(string communityId, string subjectId,
            string keyPrefix, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam,
            int pageSize, string updatedSince, FeedElementPage result)
        {
            throw new global::System.NotImplementedException(
                "ChatterFeeds.SetTestGetFeedElementsFromFilterFeedUpdatedSince");
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince,
            FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsUpdatedSince");
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince,
            FeedFilter filter, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsUpdatedSince");
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince,
            bool showInternalOnly, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsUpdatedSince");
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince,
            FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsUpdatedSince");
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize,
            string updatedSince, bool showInternalOnly, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsUpdatedSince");
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize,
            string updatedSince, bool showInternalOnly, FeedFilter filter, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsUpdatedSince");
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize,
            string updatedSince, FeedFilter filter, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedElementsUpdatedSince");
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFeed");
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, int recentCommentCount,
            FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFeed");
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string pageParam,
            int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFeed");
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId,
            FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFeed");
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            bool showInternalOnly, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFeed");
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFeed");
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId,
            string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFeed");
        }

        public static void setTestGetFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix,
            FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFilterFeed");
        }

        public static void setTestGetFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFilterFeed");
        }

        public static void setTestGetFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix,
            string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsFromFilterFeed");
        }

        public static void setTestGetFeedItemsFromFilterFeedUpdatedSince(string communityId, string subjectId,
            string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize,
            string updatedSince, FeedItemPage result)
        {
            throw new global::System.NotImplementedException(
                "ChatterFeeds.SetTestGetFeedItemsFromFilterFeedUpdatedSince");
        }

        public static void setTestGetFeedItemsUpdatedSince(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince,
            FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsUpdatedSince");
        }

        public static void setTestGetFeedItemsUpdatedSince(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince,
            bool showInternalOnly, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsUpdatedSince");
        }

        public static void setTestGetFeedItemsUpdatedSince(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince,
            FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetFeedItemsUpdatedSince");
        }

        public static void setTestGetRelatedPosts(string communityId, string feedElementId, RelatedFeedPostType filter,
            int maxResults, RelatedFeedPosts result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestGetRelatedPosts");
        }

        public static void setTestSearchFeedElements(string communityId, string q, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElements");
        }

        public static void setTestSearchFeedElements(string communityId, string q, FeedSortOrder sortParam,
            FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElements");
        }

        public static void setTestSearchFeedElements(string communityId, string q, int recentCommentCount,
            string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElements");
        }

        public static void setTestSearchFeedElements(string communityId, string q, string pageParam, int pageSize,
            FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElements");
        }

        public static void setTestSearchFeedElements(string communityId, string q, string pageParam, int pageSize,
            FeedSortOrder sortParam, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElements");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, FeedFilter filter, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string pageParam,
            int pageSize, FeedSortOrder sortParam, string q, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string q,
            FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, bool showInternalOnly, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, bool showInternalOnly, FeedFilter filter, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, FeedFilter filter, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId,
            string q, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFeed");
        }

        public static void setTestSearchFeedElementsInFilterFeed(string communityId, string subjectId, string keyPrefix,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFilterFeed");
        }

        public static void setTestSearchFeedElementsInFilterFeed(string communityId, string subjectId, string keyPrefix,
            string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFilterFeed");
        }

        public static void setTestSearchFeedElementsInFilterFeed(string communityId, string subjectId, string keyPrefix,
            string q, FeedElementPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedElementsInFilterFeed");
        }

        public static void setTestSearchFeedItems(string communityId, string q, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItems");
        }

        public static void setTestSearchFeedItems(string communityId, string q, FeedSortOrder sortParam,
            FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItems");
        }

        public static void setTestSearchFeedItems(string communityId, string q, int recentCommentCount,
            string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItems");
        }

        public static void setTestSearchFeedItems(string communityId, string q, string pageParam, int pageSize,
            FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItems");
        }

        public static void setTestSearchFeedItems(string communityId, string q, string pageParam, int pageSize,
            FeedSortOrder sortParam, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItems");
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, int recentCommentCount,
            FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFeed");
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string pageParam,
            int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFeed");
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string q,
            FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFeed");
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, bool showInternalOnly, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFeed");
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFeed");
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId,
            string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFeed");
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId,
            string q, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFeed");
        }

        public static void setTestSearchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix,
            int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam,
            string q, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFilterFeed");
        }

        public static void setTestSearchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix,
            string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFilterFeed");
        }

        public static void setTestSearchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix,
            string q, FeedItemPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchFeedItemsInFilterFeed");
        }

        public static void setTestSearchStreams(string communityId, string q, ChatterStreamPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchStreams");
        }

        public static void setTestSearchStreams(string communityId, string q, int pageParam, int pageSize,
            ChatterStreamPage result)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.SetTestSearchStreams");
        }

        public static FeedElement shareFeedElement(string communityId, string subjectId,
            FeedElementType feedElementType, string originalFeedElementId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.ShareFeedElement");
        }

        public static FeedItem shareFeedItem(string communityId, FeedType feedType, string subjectId,
            string originalFeedItemId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.ShareFeedItem");
        }

        public static FeedItem updateBookmark(string communityId, string feedItemId, bool isBookmarkedByCurrentUser)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.UpdateBookmark");
        }

        public static Comment updateComment(string communityId, string commentId, CommentInput comment)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.UpdateComment");
        }

        public static FeedElement updateFeedElement(string communityId, string feedElementId,
            FeedElementInput feedElement)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.UpdateFeedElement");
        }

        public static BookmarksCapability updateFeedElementBookmarks(string communityId, string feedElementId,
            bool isBookmarkedByCurrentUser)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.UpdateFeedElementBookmarks");
        }

        public static BookmarksCapability updateFeedElementBookmarks(string communityId, string feedElementId,
            BookmarksCapabilityInput bookmarks)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.UpdateFeedElementBookmarks");
        }

        public static ChatterLikePage updateLikeForComment(string communityId, string commentId,
            bool isLikedByCurrentUser)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.UpdateLikeForComment");
        }

        public static ChatterLikePage updateLikeForFeedElement(string communityId, string feedElementId,
            bool isLikedByCurrentUser)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.UpdateLikeForFeedElement");
        }

        public static ChatterStream updateStream(string communityId, string streamId, ChatterStreamInput streamInput)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.UpdateStream");
        }

        public static PollCapability voteOnFeedElementPoll(string communityId, string feedElementId, string myChoiceId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.VoteOnFeedElementPoll");
        }

        public static FeedPoll voteOnFeedPoll(string communityId, string feedItemId, string myChoiceId)
        {
            throw new global::System.NotImplementedException("ChatterFeeds.VoteOnFeedPoll");
        }
    }
}