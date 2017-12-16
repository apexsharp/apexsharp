namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum RecommendationExplanationType
    {
        ArticleHasRelatedContent,
        ArticleViewedTogether,
        ArticleViewedTogetherWithViewers,
        Custom,
        FilePopular,
        FileViewedTogether,
        FollowedTogetherWithFollowees,
        GroupMembersFollowed,
        GroupNew,
        GroupPopular,
        ItemViewedTogether,
        PopularApp,
        RecordOwned,
        RecordParentOfFollowed,
        RecordViewed,
        TopicFollowedTogether,
        TopicFollowedTogetherWithFollowees,
        TopicPopularFollowed,
        TopicPopularLiked,
        UserDirectReport,
        UserFollowedTogether,
        UserFollowsSameUsers,
        UserManager,
        UserNew,
        UserPeer,
        UserPopular,
        UserViewingSameRecords
    }
}
