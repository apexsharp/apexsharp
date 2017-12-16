namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_ideas.htm#apex_classes_ideas
    /// </summary>
    public class Ideas
    {
        // infrastructure
        public Ideas(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Ideas));
            }
        }

        // API
        public static ID[] findSimilar(Idea idea)
        {
            return Implementation.findSimilar(idea);
        }

        public static ID[] getAllRecentReplies(string userID, string communityID)
        {
            return Implementation.getAllRecentReplies(userID, communityID);
        }

        public static ID[] getReadRecentReplies(string userID, string communityID)
        {
            return Implementation.getReadRecentReplies(userID, communityID);
        }

        public static ID[] getUnreadRecentReplies(string userID, string communityID)
        {
            return Implementation.getUnreadRecentReplies(userID, communityID);
        }

        public static void markRead(string ideaID)
        {
            Implementation.markRead(ideaID);
        }

        public Ideas()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static List<ID> findSimilar(SObject idea)
        {
            return Implementation.findSimilar(idea);
        }
    }
}
