namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_enum_Metadata_FeedItemTypeEnum.htm
    /// </summary>
    public enum FeedItemType
    {
        ActivityEvent,
        AdvancedTextPost,
        AnnouncementPost,
        ApprovalPost,
        AttachArticleEvent,
        BasicTemplateFeedItem,
        CallLogPost,
        CanvasPost,
        CaseCommentPost,
        ChangeStatusPost,
        ChatTranscriptPost,
        CollaborationGroupCreated,
        CollaborationGroupUnarchived,
        ContentPost,
        CreateRecordEvent,
        DashboardComponentAlert,
        DashboardComponentSnapshot,
        EmailMessageEvent,
        FacebookPost,
        LinkPost,
        MilestoneEvent,
        PollPost,
        ProfileSkillPost,
        QuestionPost,
        ReplyPost,
        RypplePost,
        SocialPost,
        TestItem,
        TextPost,
        TrackedChange,
        Undefined,
        UserStatus
    }
}
