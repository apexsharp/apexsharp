using Apex.System;

namespace Apex.ConnectApi
{
    public class Mentions
    {
        public object clone()
        {
            throw new global::System.NotImplementedException("Mentions.Clone");
        }

        public static MentionCompletionPage getMentionCompletions(string communityId, string q, string contextId)
        {
            throw new global::System.NotImplementedException("Mentions.GetMentionCompletions");
        }

        public static MentionCompletionPage getMentionCompletions(string communityId, string q, string contextId,
            MentionCompletionType type, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("Mentions.GetMentionCompletions");
        }

        public static MentionValidations getMentionValidations(string communityId, string parentId,
            List<string> recordIds, FeedItemVisibilityType visibility)
        {
            throw new global::System.NotImplementedException("Mentions.GetMentionValidations");
        }

        public static void setTestGetMentionCompletions(string communityId, string q, string contextId,
            MentionCompletionPage result)
        {
            throw new global::System.NotImplementedException("Mentions.SetTestGetMentionCompletions");
        }

        public static void setTestGetMentionCompletions(string communityId, string q, string contextId,
            MentionCompletionType type, int pageParam, int pageSize, MentionCompletionPage result)
        {
            throw new global::System.NotImplementedException("Mentions.SetTestGetMentionCompletions");
        }
    }
}