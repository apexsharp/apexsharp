namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_CommunityModeration_static_methods.htm#apex_ConnectAPI_CommunityModeration_static_methods
    /// </summary>
    public class CommunityModeration
    {
        // infrastructure
        public CommunityModeration(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CommunityModeration));
            }
        }

        // API
        public static ModerationFlags addFlagToComment(string communityId, string commentId)
        {
            return Implementation.addFlagToComment(communityId, commentId);
        }

        public static ModerationFlags addFlagToComment(string communityId, string commentId, CommunityFlagVisibility visibility)
        {
            return Implementation.addFlagToComment(communityId, commentId, visibility);
        }

        public static ModerationFlags addFlagToComment(string communityId, string commentId, CommunityFlagType type)
        {
            return Implementation.addFlagToComment(communityId, commentId, type);
        }

        public static ModerationFlags addFlagToComment(string communityId, string commentId, string note)
        {
            return Implementation.addFlagToComment(communityId, commentId, note);
        }

        public static ModerationFlags addFlagToComment(string communityId, string commentId, CommunityFlagType type, string note)
        {
            return Implementation.addFlagToComment(communityId, commentId, type, note);
        }

        public static ModerationFlags addFlagToComment(string communityId, string commentId, CommunityFlagType type, CommunityFlagVisibility visibility)
        {
            return Implementation.addFlagToComment(communityId, commentId, type, visibility);
        }

        public static ModerationFlags addFlagToComment(string communityId, string commentId, CommunityFlagVisibility visibility, string note)
        {
            return Implementation.addFlagToComment(communityId, commentId, visibility, note);
        }

        public static ModerationFlags addFlagToComment(string communityId, string commentId, CommunityFlagType type, CommunityFlagVisibility visibility, string note)
        {
            return Implementation.addFlagToComment(communityId, commentId, type, visibility, note);
        }

        public static ModerationCapability addFlagToFeedElement(string communityId, string feedElementId)
        {
            return Implementation.addFlagToFeedElement(communityId, feedElementId);
        }

        public static ModerationCapability addFlagToFeedElement(string communityId, string feedElementId, CommunityFlagVisibility visibility)
        {
            return Implementation.addFlagToFeedElement(communityId, feedElementId, visibility);
        }

        public static ModerationCapability addFlagToFeedElement(string communityId, string feedElementId, CommunityFlagType type)
        {
            return Implementation.addFlagToFeedElement(communityId, feedElementId, type);
        }

        public static ModerationCapability addFlagToFeedElement(string communityId, string feedElementId, string note)
        {
            return Implementation.addFlagToFeedElement(communityId, feedElementId, note);
        }

        public static ModerationCapability addFlagToFeedElement(string communityId, string feedElementId, CommunityFlagType type, string note)
        {
            return Implementation.addFlagToFeedElement(communityId, feedElementId, type, note);
        }

        public static ModerationCapability addFlagToFeedElement(string communityId, string feedElementId, CommunityFlagType type, CommunityFlagVisibility visibility)
        {
            return Implementation.addFlagToFeedElement(communityId, feedElementId, type, visibility);
        }

        public static ModerationCapability addFlagToFeedElement(string communityId, string feedElementId, CommunityFlagVisibility visibility, string note)
        {
            return Implementation.addFlagToFeedElement(communityId, feedElementId, visibility, note);
        }

        public static ModerationCapability addFlagToFeedElement(string communityId, string feedElementId, CommunityFlagType type, CommunityFlagVisibility visibility, string note)
        {
            return Implementation.addFlagToFeedElement(communityId, feedElementId, type, visibility, note);
        }

        public static ModerationFlags addFlagToFeedItem(string communityId, string feedItemId)
        {
            return Implementation.addFlagToFeedItem(communityId, feedItemId);
        }

        public static ModerationFlags addFlagToFeedItem(string communityId, string feedItemId, CommunityFlagVisibility visibility)
        {
            return Implementation.addFlagToFeedItem(communityId, feedItemId, visibility);
        }

        public static ModerationFlags getFlagsOnComment(string communityId, string commentId)
        {
            return Implementation.getFlagsOnComment(communityId, commentId);
        }

        public static ModerationFlags getFlagsOnComment(string communityId, string commentId, CommunityFlagVisibility visibility)
        {
            return Implementation.getFlagsOnComment(communityId, commentId, visibility);
        }

        public static ModerationFlags getFlagsOnComment(string communityId, string commentId, int pageSize, string pageParam)
        {
            return Implementation.getFlagsOnComment(communityId, commentId, pageSize, pageParam);
        }

        public static ModerationFlags getFlagsOnComment(string communityId, string commentId, CommunityFlagVisibility visibility, int pageSize, string pageParam)
        {
            return Implementation.getFlagsOnComment(communityId, commentId, visibility, pageSize, pageParam);
        }

        public static ModerationCapability getFlagsOnFeedElement(string communityId, string feedElementId)
        {
            return Implementation.getFlagsOnFeedElement(communityId, feedElementId);
        }

        public static ModerationCapability getFlagsOnFeedElement(string communityId, string feedElementId, CommunityFlagVisibility visibility)
        {
            return Implementation.getFlagsOnFeedElement(communityId, feedElementId, visibility);
        }

        public static ModerationCapability getFlagsOnFeedElement(string communityId, string feedElementId, string pageParam, int pageSize)
        {
            return Implementation.getFlagsOnFeedElement(communityId, feedElementId, pageParam, pageSize);
        }

        public static ModerationCapability getFlagsOnFeedElement(string communityId, string feedElementId, CommunityFlagVisibility visibility, int pageSize, string pageParam)
        {
            return Implementation.getFlagsOnFeedElement(communityId, feedElementId, visibility, pageSize, pageParam);
        }

        public static ModerationFlags getFlagsOnFeedItem(string communityId, string feedItemId)
        {
            return Implementation.getFlagsOnFeedItem(communityId, feedItemId);
        }

        public static ModerationFlags getFlagsOnFeedItem(string communityId, string feedItemId, CommunityFlagVisibility visibility)
        {
            return Implementation.getFlagsOnFeedItem(communityId, feedItemId, visibility);
        }

        public static ModerationFlags removeFlagFromComment(string communityId, string commentId, string userId)
        {
            return Implementation.removeFlagFromComment(communityId, commentId, userId);
        }

        public static void removeFlagFromFeedElement(string communityId, string feedElementId, string userId)
        {
            Implementation.removeFlagFromFeedElement(communityId, feedElementId, userId);
        }

        public static ModerationFlags removeFlagsOnFeedItem(string communityId, string feedItemId, string userId)
        {
            return Implementation.removeFlagsOnFeedItem(communityId, feedItemId, userId);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static void removeFlagFromFeedItem(string communityId, string feedItemId, string userId)
        {
            Implementation.removeFlagFromFeedItem(communityId, feedItemId, userId);
        }
    }
}
