namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SocialEngagement
    {
        // infrastructure
        public SocialEngagement(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialEngagement));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public static DeleteSocialPostIntent deleteSocialPost(string socialPostId, string externalSocialAccountId)
        {
            return Implementation.deleteSocialPost(socialPostId, externalSocialAccountId);
        }

        public static FollowSocialPersonaIntent followSocialPersona(string socialPersonaId, string socialAccountId)
        {
            return Implementation.followSocialPersona(socialPersonaId, socialAccountId);
        }

        public static FollowSocialPersonaIntent followSocialPostPersona(string socialPostId, string socialAccountId)
        {
            return Implementation.followSocialPostPersona(socialPostId, socialAccountId);
        }

        public static SocialPostIntents getIntents(string socialPostId)
        {
            return Implementation.getIntents(socialPostId);
        }

        public static ExternalSocialAccountRelationship getRelationship(string externalSocialAccountId, string socialPersonaId)
        {
            return Implementation.getRelationship(externalSocialAccountId, socialPersonaId);
        }

        public static HideSocialPostIntent hideSocialPost(string socialPostId, string externalSocialAccountId)
        {
            return Implementation.hideSocialPost(socialPostId, externalSocialAccountId);
        }

        public static LikeSocialPostIntent likeSocialPost(string socialPostId, string externalSocialAccountId)
        {
            return Implementation.likeSocialPost(socialPostId, externalSocialAccountId);
        }

        public static void recallApproval(string socialPostId)
        {
            Implementation.recallApproval(socialPostId);
        }

        public static void unfollowSocialPersona(string socialPersonaId, string socialAccountId)
        {
            Implementation.unfollowSocialPersona(socialPersonaId, socialAccountId);
        }

        public static void unfollowSocialPostPersona(string socialPostId, string socialAccountId)
        {
            Implementation.unfollowSocialPostPersona(socialPostId, socialAccountId);
        }

        public static void unhideSocialPost(string socialPostId, string externalSocialAccountId)
        {
            Implementation.unhideSocialPost(socialPostId, externalSocialAccountId);
        }

        public static void unlikeSocialPost(string socialPostId, string externalSocialAccountId)
        {
            Implementation.unlikeSocialPost(socialPostId, externalSocialAccountId);
        }
    }
}
