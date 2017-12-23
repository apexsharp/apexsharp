namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_ChatterFeeds_static_methods.htm#apex_ConnectAPI_ChatterFeeds_static_methods
    /// </summary>
    public class ChatterFeeds
    {
        // infrastructure
        public ChatterFeeds(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterFeeds));
            }
        }

        // API
        public static ChatterStream createStream(string communityId, ChatterStreamInput streamInput)
        {
            return Implementation.createStream(communityId, streamInput);
        }

        public static void deleteComment(string communityId, string commentId)
        {
            Implementation.deleteComment(communityId, commentId);
        }

        public static void deleteFeedElement(string communityId, string feedElementId)
        {
            Implementation.deleteFeedElement(communityId, feedElementId);
        }

        public static void deleteFeedItem(string communityId, string feedItemId)
        {
            Implementation.deleteFeedItem(communityId, feedItemId);
        }

        public static void deleteLike(string communityId, string likeId)
        {
            Implementation.deleteLike(communityId, likeId);
        }

        public static void deleteStream(string communityId, string streamId)
        {
            Implementation.deleteStream(communityId, streamId);
        }

        public static Comment getComment(string communityId, string commentId)
        {
            return Implementation.getComment(communityId, commentId);
        }

        public static CommentPage getCommentsForFeedElement(string communityId, string feedElementId)
        {
            return Implementation.getCommentsForFeedElement(communityId, feedElementId);
        }

        public static CommentPage getCommentsForFeedElement(string communityId, string feedElementId, string pageParam, int pageSize)
        {
            return Implementation.getCommentsForFeedElement(communityId, feedElementId, pageParam, pageSize);
        }

        public static CommentsCapability getCommentsForFeedElement(string communityId, string feedElementId, FeedCommentSortOrder sortParam)
        {
            return Implementation.getCommentsForFeedElement(communityId, feedElementId, sortParam);
        }

        public static CommentPage getCommentsForFeedItem(string communityId, string feedItemId)
        {
            return Implementation.getCommentsForFeedItem(communityId, feedItemId);
        }

        public static CommentPage getCommentsForFeedItem(string communityId, string feedItemId, string pageParam, int pageSize)
        {
            return Implementation.getCommentsForFeedItem(communityId, feedItemId, pageParam, pageSize);
        }

        public static ExtensionDefinitions getExtensions(string communityId, string pageParam, int pageSize)
        {
            return Implementation.getExtensions(communityId, pageParam, pageSize);
        }

        public static Feed getFeed(string communityId, FeedType feedType)
        {
            return Implementation.getFeed(communityId, feedType);
        }

        public static Feed getFeed(string communityId, FeedType feedType, FeedSortOrder sortParam)
        {
            return Implementation.getFeed(communityId, feedType, sortParam);
        }

        public static Feed getFeed(string communityId, FeedType feedType, string subjectId)
        {
            return Implementation.getFeed(communityId, feedType, subjectId);
        }

        public static Feed getFeed(string communityId, FeedType feedType, string subjectId, FeedSortOrder sortParam)
        {
            return Implementation.getFeed(communityId, feedType, subjectId, sortParam);
        }

        public static FeedDirectory getFeedDirectory(string communityId)
        {
            return Implementation.getFeedDirectory(communityId);
        }

        public static FeedElement getFeedElement(string communityId, string feedElementId)
        {
            return Implementation.getFeedElement(communityId, feedElementId);
        }

        public static FeedElement getFeedElement(string communityId, string feedElementId, FeedCommentSortOrder commentSort)
        {
            return Implementation.getFeedElement(communityId, feedElementId, commentSort);
        }

        public static FeedElement getFeedElement(string communityId, string feedElementId, int recentCommentCount, int elementsPerBundle)
        {
            return Implementation.getFeedElement(communityId, feedElementId, recentCommentCount, elementsPerBundle);
        }

        public static FeedElement getFeedElement(string communityId, string feedElementId, int recentCommentCount, int elementsPerBundle, FeedCommentSortOrder commentSort)
        {
            return Implementation.getFeedElement(communityId, feedElementId, recentCommentCount, elementsPerBundle, commentSort);
        }

        public static BatchResult[] getFeedElementBatch(string communityId, List<string> feedElementIds)
        {
            return Implementation.getFeedElementBatch(communityId, feedElementIds);
        }

        public static PollCapability getFeedElementPoll(string communityId, string feedElementId)
        {
            return Implementation.getFeedElementPoll(communityId, feedElementId);
        }

        public static FeedElementPage getFeedElementsFromBundle(string communityId, string feedElementId)
        {
            return Implementation.getFeedElementsFromBundle(communityId, feedElementId);
        }

        public static FeedElementPage getFeedElementsFromBundle(string communityId, string feedElementId, string pageParam, int pageSize, int elementsPerBundle, int recentCommentCount)
        {
            return Implementation.getFeedElementsFromBundle(communityId, feedElementId, pageParam, pageSize, elementsPerBundle, recentCommentCount);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, pageParam, pageSize, sortParam);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedFilter filter)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, filter);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, subjectId);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, subjectId, pageParam, pageSize, sortParam);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, showInternalOnly);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedFilter filter)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, filter);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string customFilter)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, customFilter);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, sortParam, showInternalOnly);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly, FeedFilter filter)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, sortParam, showInternalOnly, filter);
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly, string customFilter)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, sortParam, showInternalOnly, customFilter);
        }

        public static FeedElementPage getFeedElementsFromFilterFeed(string communityId, string subjectId, string keyPrefix)
        {
            return Implementation.getFeedElementsFromFilterFeed(communityId, subjectId, keyPrefix);
        }

        public static FeedElementPage getFeedElementsFromFilterFeed(string communityId, string subjectId, string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedElementsFromFilterFeed(communityId, subjectId, keyPrefix, pageParam, pageSize, sortParam);
        }

        public static FeedElementPage getFeedElementsFromFilterFeed(string communityId, string subjectId, string keyPrefix, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedElementsFromFilterFeed(communityId, subjectId, keyPrefix, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, sortParam);
        }

        public static FeedElementPage getFeedElementsFromFilterFeedUpdatedSince(string communityId, string subjectId, string keyPrefix, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince)
        {
            return Implementation.getFeedElementsFromFilterFeedUpdatedSince(communityId, subjectId, keyPrefix, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, recentCommentCount, density, pageParam, pageSize, updatedSince);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedFilter filter)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, recentCommentCount, density, pageParam, pageSize, updatedSince, filter);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, updatedSince);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, updatedSince, showInternalOnly);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedFilter filter)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, filter);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, string customFilter)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, customFilter);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, showInternalOnly);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly, FeedFilter filter)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, showInternalOnly, filter);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly, string customFilter)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, showInternalOnly, customFilter);
        }

        public static FeedItem getFeedItem(string communityId, string feedItemId)
        {
            return Implementation.getFeedItem(communityId, feedItemId);
        }

        public static BatchResult[] getFeedItemBatch(string communityId, List<string> feedItemIds)
        {
            return Implementation.getFeedItemBatch(communityId, feedItemIds);
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType)
        {
            return Implementation.getFeedItemsFromFeed(communityId, feedType);
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedItemsFromFeed(communityId, feedType, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedItemsFromFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId)
        {
            return Implementation.getFeedItemsFromFeed(communityId, feedType, subjectId);
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedItemsFromFeed(communityId, feedType, subjectId, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedItemsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage getFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly)
        {
            return Implementation.getFeedItemsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, showInternalOnly);
        }

        public static FeedItemPage getFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix)
        {
            return Implementation.getFeedItemsFromFilterFeed(communityId, subjectId, keyPrefix);
        }

        public static FeedItemPage getFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedItemsFromFilterFeed(communityId, subjectId, keyPrefix, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage getFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.getFeedItemsFromFilterFeed(communityId, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage getFeedItemsFromFilterFeedUpdatedSince(string communityId, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince)
        {
            return Implementation.getFeedItemsFromFilterFeedUpdatedSince(communityId, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, updatedSince);
        }

        public static FeedItemPage getFeedItemsUpdatedSince(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince)
        {
            return Implementation.getFeedItemsUpdatedSince(communityId, feedType, recentCommentCount, density, pageParam, pageSize, updatedSince);
        }

        public static FeedItemPage getFeedItemsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince)
        {
            return Implementation.getFeedItemsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, updatedSince);
        }

        public static FeedItemPage getFeedItemsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly)
        {
            return Implementation.getFeedItemsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, updatedSince, showInternalOnly);
        }

        public static FeedPoll getFeedPoll(string communityId, string feedItemId)
        {
            return Implementation.getFeedPoll(communityId, feedItemId);
        }

        public static Feed getFeedWithFeedElements(string communityId, FeedType feedType, int pageSize)
        {
            return Implementation.getFeedWithFeedElements(communityId, feedType, pageSize);
        }

        public static Feed getFeedWithFeedElements(string communityId, FeedType feedType, int pageSize, int recentCommentCount)
        {
            return Implementation.getFeedWithFeedElements(communityId, feedType, pageSize, recentCommentCount);
        }

        public static Feed getFilterFeed(string communityId, string subjectId, string keyPrefix)
        {
            return Implementation.getFilterFeed(communityId, subjectId, keyPrefix);
        }

        public static Feed getFilterFeed(string communityId, string subjectId, string keyPrefix, FeedType sortParam)
        {
            return Implementation.getFilterFeed(communityId, subjectId, keyPrefix, sortParam);
        }

        public static FeedDirectory getFilterFeedDirectory(string communityId, string subjectId)
        {
            return Implementation.getFilterFeedDirectory(communityId, subjectId);
        }

        public static ChatterLike getLike(string communityId, string likeId)
        {
            return Implementation.getLike(communityId, likeId);
        }

        public static ChatterLikePage getLikesForComment(string communityId, string commentId)
        {
            return Implementation.getLikesForComment(communityId, commentId);
        }

        public static ChatterLikePage getLikesForComment(string communityId, string commentId, int pageParam, int pageSize)
        {
            return Implementation.getLikesForComment(communityId, commentId, pageParam, pageSize);
        }

        public static ChatterLikePage getLikesForFeedElement(string communityId, string feedElementId)
        {
            return Implementation.getLikesForFeedElement(communityId, feedElementId);
        }

        public static ChatterLikePage getLikesForFeedElement(string communityId, string feedElementId, int pageParam, int pageSize)
        {
            return Implementation.getLikesForFeedElement(communityId, feedElementId, pageParam, pageSize);
        }

        public static ChatterLikePage getLikesForFeedItem(string communityId, string feedItemId)
        {
            return Implementation.getLikesForFeedItem(communityId, feedItemId);
        }

        public static ChatterLikePage getLikesForFeedItem(string communityId, string feedItemId, int pageParam, int pageSize)
        {
            return Implementation.getLikesForFeedItem(communityId, feedItemId, pageParam, pageSize);
        }

        public static PinnedFeedElements getPinnedFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId)
        {
            return Implementation.getPinnedFeedElementsFromFeed(communityId, feedType, subjectId);
        }

        public static ReadByPage getReadByForFeedElement(string communityId, string feedElementId)
        {
            return Implementation.getReadByForFeedElement(communityId, feedElementId);
        }

        public static ReadByPage getReadByForFeedElement(string communityId, string feedElementId, int pageParam, int pageSize)
        {
            return Implementation.getReadByForFeedElement(communityId, feedElementId, pageParam, pageSize);
        }

        public static RelatedFeedPosts getRelatedPosts(string communityId, string feedElementId, RelatedFeedPostType filter, int maxResults)
        {
            return Implementation.getRelatedPosts(communityId, feedElementId, filter, maxResults);
        }

        public static ChatterStream getStream(string communityId, string streamId)
        {
            return Implementation.getStream(communityId, streamId);
        }

        public static ChatterStream getStream(string communityId, string streamId, bool globalScope)
        {
            return Implementation.getStream(communityId, streamId, globalScope);
        }

        public static ChatterStreamPage getStreams(string communityId)
        {
            return Implementation.getStreams(communityId);
        }

        public static ChatterStreamPage getStreams(string communityId, SortOrder sortParam)
        {
            return Implementation.getStreams(communityId, sortParam);
        }

        public static ChatterStreamPage getStreams(string communityId, int pageParam, int pageSize)
        {
            return Implementation.getStreams(communityId, pageParam, pageSize);
        }

        public static ChatterStreamPage getStreams(string communityId, int pageParam, int pageSize, SortOrder sortParam)
        {
            return Implementation.getStreams(communityId, pageParam, pageSize, sortParam);
        }

        public static ChatterStreamPage getStreams(string communityId, int pageParam, int pageSize, SortOrder sortParam, bool globalScope)
        {
            return Implementation.getStreams(communityId, pageParam, pageSize, sortParam, globalScope);
        }

        public static SupportedEmojis getSupportedEmojis()
        {
            return Implementation.getSupportedEmojis();
        }

        public static FeedEntityIsEditable isCommentEditableByMe(string communityId, string commentId)
        {
            return Implementation.isCommentEditableByMe(communityId, commentId);
        }

        public static FeedEntityIsEditable isFeedElementEditableByMe(string communityId, string feedElementId)
        {
            return Implementation.isFeedElementEditableByMe(communityId, feedElementId);
        }

        public static FeedModifiedInfo isModified(string communityId, FeedType feedType, string subjectId, string since)
        {
            return Implementation.isModified(communityId, feedType, subjectId, since);
        }

        public static ChatterLike likeComment(string communityId, string commentId)
        {
            return Implementation.likeComment(communityId, commentId);
        }

        public static ChatterLike likeFeedElement(string communityId, string feedElementId)
        {
            return Implementation.likeFeedElement(communityId, feedElementId);
        }

        public static ChatterLike likeFeedItem(string communityId, string feedItemId)
        {
            return Implementation.likeFeedItem(communityId, feedItemId);
        }

        public static Comment postComment(string communityId, string feedItemId, string text)
        {
            return Implementation.postComment(communityId, feedItemId, text);
        }

        public static Comment postComment(string communityId, string feedItemId, CommentInput comment, BinaryInput feedItemFileUpload)
        {
            return Implementation.postComment(communityId, feedItemId, comment, feedItemFileUpload);
        }

        public static Comment postCommentToFeedElement(string communityId, string feedElementId, string text)
        {
            return Implementation.postCommentToFeedElement(communityId, feedElementId, text);
        }

        public static Comment postCommentToFeedElement(string communityId, string feedElementId, CommentInput comment, BinaryInput feedElementFileUpload)
        {
            return Implementation.postCommentToFeedElement(communityId, feedElementId, comment, feedElementFileUpload);
        }

        public static FeedElement postFeedElement(string communityId, string subjectId, FeedElementType feedElementType, string text)
        {
            return Implementation.postFeedElement(communityId, subjectId, feedElementType, text);
        }

        public static FeedElement postFeedElement(string communityId, FeedElementInput feedElement, BinaryInput feedElementFileUpload)
        {
            return Implementation.postFeedElement(communityId, feedElement, feedElementFileUpload);
        }

        public static FeedElement postFeedElement(string communityId, FeedElementInput feedElement)
        {
            return Implementation.postFeedElement(communityId, feedElement);
        }

        public static BatchResult[] postFeedElementBatch(string communityId, List<BatchInput> feedElements)
        {
            return Implementation.postFeedElementBatch(communityId, feedElements);
        }

        public static FeedItem postFeedItem(string communityId, FeedType feedType, string subjectId, string text)
        {
            return Implementation.postFeedItem(communityId, feedType, subjectId, text);
        }

        public static FeedItem postFeedItem(string communityId, FeedType feedType, string subjectId, FeedItemInput feedItemInput, BinaryInput feedItemFileUpload)
        {
            return Implementation.postFeedItem(communityId, feedType, subjectId, feedItemInput, feedItemFileUpload);
        }

        public static FeedElementPage searchFeedElements(string communityId, string q)
        {
            return Implementation.searchFeedElements(communityId, q);
        }

        public static FeedElementPage searchFeedElements(string communityId, string q, FeedSortOrder sortParam)
        {
            return Implementation.searchFeedElements(communityId, q, sortParam);
        }

        public static FeedElementPage searchFeedElements(string communityId, string q, string pageParam, int pageSize)
        {
            return Implementation.searchFeedElements(communityId, q, pageParam, pageSize);
        }

        public static FeedElementPage searchFeedElements(string communityId, string q, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.searchFeedElements(communityId, q, pageParam, pageSize, sortParam);
        }

        public static FeedElementPage searchFeedElements(string communityId, string q, int recentCommentCount, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.searchFeedElements(communityId, q, recentCommentCount, pageParam, pageSize, sortParam);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string q)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, q);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, pageParam, pageSize, sortParam, q);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, q);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedFilter filter)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, q, filter);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, string q)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, subjectId, q);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, subjectId, pageParam, pageSize, sortParam, q);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedFilter filter)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, filter);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, string customFilter)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, customFilter);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, bool showInternalOnly)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, showInternalOnly);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, bool showInternalOnly, FeedFilter filter)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, showInternalOnly, filter);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, bool showInternalOnly, string customFilter)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, showInternalOnly, customFilter);
        }

        public static FeedElementPage searchFeedElementsInFilterFeed(string communityId, string subjectId, string keyPrefix, string q)
        {
            return Implementation.searchFeedElementsInFilterFeed(communityId, subjectId, keyPrefix, q);
        }

        public static FeedElementPage searchFeedElementsInFilterFeed(string communityId, string subjectId, string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedElementsInFilterFeed(communityId, subjectId, keyPrefix, pageParam, pageSize, sortParam, q);
        }

        public static FeedElementPage searchFeedElementsInFilterFeed(string communityId, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedElementsInFilterFeed(communityId, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, sortParam, q);
        }

        public static FeedItemPage searchFeedItems(string communityId, string q)
        {
            return Implementation.searchFeedItems(communityId, q);
        }

        public static FeedItemPage searchFeedItems(string communityId, string q, FeedSortOrder sortParam)
        {
            return Implementation.searchFeedItems(communityId, q, sortParam);
        }

        public static FeedItemPage searchFeedItems(string communityId, string q, string pageParam, int pageSize)
        {
            return Implementation.searchFeedItems(communityId, q, pageParam, pageSize);
        }

        public static FeedItemPage searchFeedItems(string communityId, string q, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.searchFeedItems(communityId, q, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage searchFeedItems(string communityId, string q, int recentCommentCount, string pageParam, int pageSize, FeedSortOrder sortParam)
        {
            return Implementation.searchFeedItems(communityId, q, recentCommentCount, pageParam, pageSize, sortParam);
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string q)
        {
            return Implementation.searchFeedItemsInFeed(communityId, feedType, q);
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedItemsInFeed(communityId, feedType, pageParam, pageSize, sortParam, q);
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedItemsInFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, q);
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId, string q)
        {
            return Implementation.searchFeedItemsInFeed(communityId, feedType, subjectId, q);
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedItemsInFeed(communityId, feedType, subjectId, pageParam, pageSize, sortParam, q);
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedItemsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q);
        }

        public static FeedItemPage searchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, bool showInternalOnly)
        {
            return Implementation.searchFeedItemsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, showInternalOnly);
        }

        public static FeedItemPage searchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix, string q)
        {
            return Implementation.searchFeedItemsInFilterFeed(communityId, subjectId, keyPrefix, q);
        }

        public static FeedItemPage searchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedItemsInFilterFeed(communityId, subjectId, keyPrefix, pageParam, pageSize, sortParam, q);
        }

        public static FeedItemPage searchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q)
        {
            return Implementation.searchFeedItemsInFilterFeed(communityId, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, sortParam, q);
        }

        public static ChatterStreamPage searchStreams(string communityId, string q)
        {
            return Implementation.searchStreams(communityId, q);
        }

        public static ChatterStreamPage searchStreams(string communityId, string q, SortOrder sortParam)
        {
            return Implementation.searchStreams(communityId, q, sortParam);
        }

        public static ChatterStreamPage searchStreams(string communityId, string q, int pageParam, int pageSize)
        {
            return Implementation.searchStreams(communityId, q, pageParam, pageSize);
        }

        public static ChatterStreamPage searchStreams(string communityId, string q, int pageParam, int pageSize, SortOrder sortParam)
        {
            return Implementation.searchStreams(communityId, q, pageParam, pageSize, sortParam);
        }

        public static ChatterStreamPage searchStreams(string communityId, string q, int pageParam, int pageSize, SortOrder sortParam, bool globalScope)
        {
            return Implementation.searchStreams(communityId, q, pageParam, pageSize, sortParam, globalScope);
        }

        public static VerifiedCapability setCommentIsVerified(string communityId, string commentId, bool isVerified)
        {
            return Implementation.setCommentIsVerified(communityId, commentId, isVerified);
        }

        public static UpDownVoteCapability setCommentVote(string communityId, string commentId, UpDownVoteCapabilityInput upDownVote)
        {
            return Implementation.setCommentVote(communityId, commentId, upDownVote);
        }

        public static StatusCapability setFeedCommentStatus(string communityId, string commentId, StatusCapabilityInput status)
        {
            return Implementation.setFeedCommentStatus(communityId, commentId, status);
        }

        public static UpDownVoteCapability setFeedElementVote(string communityId, string feedElementId, UpDownVoteCapabilityInput upDownVote)
        {
            return Implementation.setFeedElementVote(communityId, feedElementId, upDownVote);
        }

        public static StatusCapability setFeedEntityStatus(string communityId, string feedElementId, StatusCapabilityInput status)
        {
            return Implementation.setFeedEntityStatus(communityId, feedElementId, status);
        }

        public static MuteCapability setIsMutedByMe(string communityId, string feedElementId, bool isMutedByMe)
        {
            return Implementation.setIsMutedByMe(communityId, feedElementId, isMutedByMe);
        }

        public static ReadByCapability setIsReadByMe(string communityId, string feedElementId, ReadByCapabilityInput readBy)
        {
            return Implementation.setIsReadByMe(communityId, feedElementId, readBy);
        }

        public static ReadByCapability setIsReadByMe(string communityId, string feedElementId, bool isReadByMe)
        {
            return Implementation.setIsReadByMe(communityId, feedElementId, isReadByMe);
        }

        public static FeedElement shareFeedElement(string communityId, string subjectId, FeedElementType feedElementType, string originalFeedElementId)
        {
            return Implementation.shareFeedElement(communityId, subjectId, feedElementType, originalFeedElementId);
        }

        public static FeedItem shareFeedItem(string communityId, FeedType feedType, string subjectId, string originalFeedItemId)
        {
            return Implementation.shareFeedItem(communityId, feedType, subjectId, originalFeedItemId);
        }

        public static FeedItem updateBookmark(string communityId, string feedItemId, bool isBookmarkedByCurrentUser)
        {
            return Implementation.updateBookmark(communityId, feedItemId, isBookmarkedByCurrentUser);
        }

        public static Comment updateComment(string communityId, string commentId, CommentInput comment)
        {
            return Implementation.updateComment(communityId, commentId, comment);
        }

        public static DirectMessageCapability updateDirectMessage(string communityId, string feedElementId, DirectMessageCapabilityInput directMessage)
        {
            return Implementation.updateDirectMessage(communityId, feedElementId, directMessage);
        }

        public static FeedElement updateFeedElement(string communityId, string feedElementId, FeedElementInput feedElement)
        {
            return Implementation.updateFeedElement(communityId, feedElementId, feedElement);
        }

        public static BookmarksCapability updateFeedElementBookmarks(string communityId, string feedElementId, BookmarksCapabilityInput bookmarks)
        {
            return Implementation.updateFeedElementBookmarks(communityId, feedElementId, bookmarks);
        }

        public static BookmarksCapability updateFeedElementBookmarks(string communityId, string feedElementId, bool isBookmarkedByCurrentUser)
        {
            return Implementation.updateFeedElementBookmarks(communityId, feedElementId, isBookmarkedByCurrentUser);
        }

        public static BatchResult[] updateFeedElementReadByCapabilityBatch(string communityId, List<string> feedElementIds, ReadByCapabilityInput readBy)
        {
            return Implementation.updateFeedElementReadByCapabilityBatch(communityId, feedElementIds, readBy);
        }

        public static BatchResult[] updateFeedElementReadByCapabilityBatch(string communityId, List<string> feedElementIds, bool isReadByMe)
        {
            return Implementation.updateFeedElementReadByCapabilityBatch(communityId, feedElementIds, isReadByMe);
        }

        public static ChatterLikePage updateLikeForComment(string communityId, string commentId, bool isLikedByCurrentUser)
        {
            return Implementation.updateLikeForComment(communityId, commentId, isLikedByCurrentUser);
        }

        public static ChatterLikePage updateLikeForFeedElement(string communityId, string feedElementId, bool isLikedByCurrentUser)
        {
            return Implementation.updateLikeForFeedElement(communityId, feedElementId, isLikedByCurrentUser);
        }

        public static PinCapability updatePinnedFeedElements(string communityId, FeedType feedType, string subjectId, PinCapabilityInput pin)
        {
            return Implementation.updatePinnedFeedElements(communityId, feedType, subjectId, pin);
        }

        public static ChatterStream updateStream(string communityId, string streamId, ChatterStreamInput streamInput)
        {
            return Implementation.updateStream(communityId, streamId, streamInput);
        }

        public static PollCapability voteOnFeedElementPoll(string communityId, string feedElementId, string myChoiceId)
        {
            return Implementation.voteOnFeedElementPoll(communityId, feedElementId, myChoiceId);
        }

        public static FeedPoll voteOnFeedPoll(string communityId, string feedItemId, string myChoiceId)
        {
            return Implementation.voteOnFeedPoll(communityId, feedItemId, myChoiceId);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedFilter filter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, filter, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, subjectId, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, subjectId, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, showInternalOnly, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedFilter filter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, filter, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string customFilter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, customFilter, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, sortParam, showInternalOnly, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly, FeedFilter filter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, sortParam, showInternalOnly, filter, result);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly, string customFilter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, sortParam, showInternalOnly, customFilter, result);
        }

        public static void setTestGetFeedElementsFromFilterFeed(string communityId, string subjectId, string keyPrefix, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFilterFeed(communityId, subjectId, keyPrefix, result);
        }

        public static void setTestGetFeedElementsFromFilterFeed(string communityId, string subjectId, string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFilterFeed(communityId, subjectId, keyPrefix, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedElementsFromFilterFeed(string communityId, string subjectId, string keyPrefix, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFilterFeed(communityId, subjectId, keyPrefix, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedElementsFromFilterFeedUpdatedSince(string communityId, string subjectId, string keyPrefix, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFilterFeedUpdatedSince(communityId, subjectId, keyPrefix, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, recentCommentCount, density, pageParam, pageSize, updatedSince, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedFilter filter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, recentCommentCount, density, pageParam, pageSize, updatedSince, filter, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, updatedSince, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, updatedSince, showInternalOnly, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedFilter filter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, filter, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, string customFilter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, customFilter, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, showInternalOnly, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly, FeedFilter filter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, showInternalOnly, filter, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, int elementsPerBundle, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly, string customFilter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, elementsPerBundle, density, pageParam, pageSize, updatedSince, showInternalOnly, customFilter, result);
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFeed(communityId, feedType, result);
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFeed(communityId, feedType, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFeed(communityId, feedType, subjectId, result);
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFeed(communityId, feedType, subjectId, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedItemsFromFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, bool showInternalOnly, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, showInternalOnly, result);
        }

        public static void setTestGetFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFilterFeed(communityId, subjectId, keyPrefix, result);
        }

        public static void setTestGetFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFilterFeed(communityId, subjectId, keyPrefix, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedItemsFromFilterFeed(string communityId, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFilterFeed(communityId, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, sortParam, result);
        }

        public static void setTestGetFeedItemsFromFilterFeedUpdatedSince(string communityId, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string updatedSince, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFilterFeedUpdatedSince(communityId, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, sortParam, updatedSince, result);
        }

        public static void setTestGetFeedItemsUpdatedSince(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedItemPage results)
        {
            Implementation.setTestGetFeedItemsUpdatedSince(communityId, feedType, recentCommentCount, density, pageParam, pageSize, updatedSince, results);
        }

        public static void setTestGetFeedItemsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, updatedSince, result);
        }

        public static void setTestGetFeedItemsUpdatedSince(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, bool showInternalOnly, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsUpdatedSince(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, updatedSince, showInternalOnly, result);
        }

        public static void setTestGetRelatedPosts(string communityId, string feedElementId, RelatedFeedPostType filter, int maxResults, RelatedFeedPosts result)
        {
            Implementation.setTestGetRelatedPosts(communityId, feedElementId, filter, maxResults, result);
        }

        public static void setTestSearchFeedElements(string communityId, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElements(communityId, q, result);
        }

        public static void setTestSearchFeedElements(string communityId, string q, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElements(communityId, q, sortParam, result);
        }

        public static void setTestSearchFeedElements(string communityId, string q, string pageParam, int pageSize, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElements(communityId, q, pageParam, pageSize, result);
        }

        public static void setTestSearchFeedElements(string communityId, string q, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElements(communityId, q, pageParam, pageSize, sortParam, result);
        }

        public static void setTestSearchFeedElements(string communityId, string q, int recentCommentCount, string pageParam, int pageSize, FeedSortOrder sortParam, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElements(communityId, q, recentCommentCount, pageParam, pageSize, sortParam, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, q, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedFilter filter, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, q, filter, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, subjectId, q, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, subjectId, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedFilter filter, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, filter, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, string customFilter, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, customFilter, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, bool showInternalOnly, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, showInternalOnly, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, bool showInternalOnly, FeedFilter filter, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, showInternalOnly, filter, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, bool showInternalOnly, string customFilter, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, showInternalOnly, customFilter, result);
        }

        public static void setTestSearchFeedElementsInFilterFeed(string communityId, string subjectId, string keyPrefix, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFilterFeed(communityId, subjectId, keyPrefix, q, result);
        }

        public static void setTestSearchFeedElementsInFilterFeed(string communityId, string subjectId, string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFilterFeed(communityId, subjectId, keyPrefix, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedElementsInFilterFeed(string communityId, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFilterFeed(communityId, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, sortParam, q, result);
        }

        public static void searchFeedItems(string communityId, string q, FeedItemPage result)
        {
            Implementation.searchFeedItems(communityId, q, result);
        }

        public static void setTestSearchFeedItems(string communityId, string q, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItems(communityId, q, sortParam, result);
        }

        public static void setTestSearchFeedItems(string communityId, string q, string pageParam, int pageSize, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItems(communityId, q, pageParam, pageSize, result);
        }

        public static void setTestSearchFeedItems(string communityId, string q, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItems(communityId, q, pageParam, pageSize, sortParam, result);
        }

        public static void setTestSearchFeedItems(string communityId, string q, int recentCommentCount, string pageParam, int pageSize, FeedSortOrder sortParam, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItems(communityId, q, recentCommentCount, pageParam, pageSize, sortParam, result);
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFeed(communityId, feedType, q, result);
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFeed(communityId, feedType, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFeed(communityId, feedType, subjectId, q, result);
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFeed(communityId, feedType, subjectId, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedItemsInFeed(string communityId, FeedType feedType, string subjectId, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, bool showInternalOnly, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFeed(communityId, feedType, subjectId, recentCommentCount, density, pageParam, pageSize, sortParam, q, showInternalOnly, result);
        }

        public static void setTestSearchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFilterFeed(communityId, subjectId, keyPrefix, q, result);
        }

        public static void setTestSearchFeedItemsInFilterFeed(string communityId, FeedType feedType, string subjectId, string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFilterFeed(communityId, feedType, subjectId, keyPrefix, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedItemsInFilterFeed(string communityId, FeedType feedType, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFilterFeed(communityId, feedType, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchStreams(string communityId, string q, ChatterStreamPage result)
        {
            Implementation.setTestSearchStreams(communityId, q, result);
        }

        public static void setTestSearchStreams(string communityId, string q, SortOrder sortParam, ChatterStreamPage result)
        {
            Implementation.setTestSearchStreams(communityId, q, sortParam, result);
        }

        public static void setTestSearchStreams(string communityId, string q, int pageParam, int pageSize, ChatterStreamPage result)
        {
            Implementation.setTestSearchStreams(communityId, q, pageParam, pageSize, result);
        }

        public static void setTestSearchStreams(string communityId, string q, int pageParam, int pageSize, SortOrder sortParam, ChatterStreamPage result)
        {
            Implementation.setTestSearchStreams(communityId, q, pageParam, pageSize, sortParam, result);
        }

        public static void setTestSearchStreams(string communityId, string q, int pageParam, int pageSize, SortOrder sortParam, bool globalScope, ChatterStreamPage result)
        {
            Implementation.setTestSearchStreams(communityId, q, pageParam, pageSize, sortParam, globalScope, result);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static FeedElementPage getFeedElementsFromFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string customFilter)
        {
            return Implementation.getFeedElementsFromFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, customFilter);
        }

        public static FeedElementPage getFeedElementsUpdatedSince(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, string customFilter)
        {
            return Implementation.getFeedElementsUpdatedSince(communityId, feedType, recentCommentCount, density, pageParam, pageSize, updatedSince, customFilter);
        }

        public static Feed getFilterFeed(string communityId, string subjectId, string keyPrefix, FeedSortOrder sortParam)
        {
            return Implementation.getFilterFeed(communityId, subjectId, keyPrefix, sortParam);
        }

        public static ReadByPage getReadByForFeedElement(string communityId, string feedElementId, string pageParam, int pageSize)
        {
            return Implementation.getReadByForFeedElement(communityId, feedElementId, pageParam, pageSize);
        }

        public static FeedElementPage searchFeedElementsInFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, string customFilter)
        {
            return Implementation.searchFeedElementsInFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, q, customFilter);
        }

        public static void setTestGetFeedElementsFromFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string customFilter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsFromFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, customFilter, result);
        }

        public static void setTestGetFeedElementsUpdatedSince(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, string customFilter, FeedElementPage result)
        {
            Implementation.setTestGetFeedElementsUpdatedSince(communityId, feedType, recentCommentCount, density, pageParam, pageSize, updatedSince, customFilter, result);
        }

        public static void setTestGetFeedItemsFromFilterFeedUpdatedSince(string communityId, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, string updatedSince, FeedItemPage result)
        {
            Implementation.setTestGetFeedItemsFromFilterFeedUpdatedSince(communityId, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, updatedSince, result);
        }

        public static void setTestSearchFeedElementsInFeed(string communityId, FeedType feedType, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, string customFilter, FeedElementPage result)
        {
            Implementation.setTestSearchFeedElementsInFeed(communityId, feedType, recentCommentCount, density, pageParam, pageSize, sortParam, q, customFilter, result);
        }

        public static void setTestSearchFeedItems(string communityId, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItems(communityId, q, result);
        }

        public static void setTestSearchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix, int recentCommentCount, FeedDensity density, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFilterFeed(communityId, subjectId, keyPrefix, recentCommentCount, density, pageParam, pageSize, sortParam, q, result);
        }

        public static void setTestSearchFeedItemsInFilterFeed(string communityId, string subjectId, string keyPrefix, string pageParam, int pageSize, FeedSortOrder sortParam, string q, FeedItemPage result)
        {
            Implementation.setTestSearchFeedItemsInFilterFeed(communityId, subjectId, keyPrefix, pageParam, pageSize, sortParam, q, result);
        }
    }
}
