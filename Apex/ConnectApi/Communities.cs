namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Communities_static_methods.htm#apex_ConnectAPI_Communities_static_methods
    /// </summary>
    public class Communities
    {
        // infrastructure
        public Communities(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Communities));
            }
        }

        // API
        public static CommunityPage getCommunities()
        {
            return Implementation.getCommunities();
        }

        public static CommunityPage getCommunities(CommunityStatus communityStatus)
        {
            return Implementation.getCommunities(communityStatus);
        }

        public static Community getCommunity(string communityId)
        {
            return Implementation.getCommunity(communityId);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
