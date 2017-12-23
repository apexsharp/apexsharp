namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Chatter_static_methods.htm#apex_ConnectAPI_Chatter_static_methods
    /// </summary>
    public class Chatter
    {
        // infrastructure
        public Chatter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Chatter));
            }
        }

        // API
        public static void deleteSubscription(string communityId, string subscriptionId)
        {
            Implementation.deleteSubscription(communityId, subscriptionId);
        }

        public static FollowerPage getFollowers(string communityId, string recordId)
        {
            return Implementation.getFollowers(communityId, recordId);
        }

        public static FollowerPage getFollowers(string communityId, string recordId, int pageParam, int pageSize)
        {
            return Implementation.getFollowers(communityId, recordId, pageParam, pageSize);
        }

        public static Subscription getSubscription(string communityId, string subscriptionId)
        {
            return Implementation.getSubscription(communityId, subscriptionId);
        }

        public static DigestJobRepresentation submitDigestJob(DigestPeriod period)
        {
            return Implementation.submitDigestJob(period);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
