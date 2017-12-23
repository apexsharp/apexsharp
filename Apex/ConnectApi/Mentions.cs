namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Mentions_static_methods.htm#apex_ConnectAPI_Mentions_static_methods
    /// </summary>
    public class Mentions
    {
        // infrastructure
        public Mentions(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Mentions));
            }
        }

        // API
        public static MentionCompletionPage getMentionCompletions(string communityId, string q, string contextId)
        {
            return Implementation.getMentionCompletions(communityId, q, contextId);
        }

        public static Mentions getMentionCompletions(string communityId, string q, string contextId, MentionCompletionType type, int pageParam, int pageSize)
        {
            return Implementation.getMentionCompletions(communityId, q, contextId, type, pageParam, pageSize);
        }

        public static Mentions getMentionValidations(string communityId, string parentId, List<string> recordIds, FeedItemVisibilityType visibility)
        {
            return Implementation.getMentionValidations(communityId, parentId, recordIds, visibility);
        }

        public static void setTestGetMentionCompletions(string communityId, string q, string contextId, MentionCompletionPage result)
        {
            Implementation.setTestGetMentionCompletions(communityId, q, contextId, result);
        }

        public static void setTestGetMentionCompletions(string communityId, string q, string contextId, MentionCompletionType type, int pageParam, int pageSize, MentionCompletionPage result)
        {
            Implementation.setTestGetMentionCompletions(communityId, q, contextId, type, pageParam, pageSize, result);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
