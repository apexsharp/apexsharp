namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_CommunitiesUtil.htm#apex_class_Auth_CommunitiesUtil
    /// </summary>
    public class CommunitiesUtil
    {
        // infrastructure
        public CommunitiesUtil(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CommunitiesUtil));
            }
        }

        // API
        public static string getLogoutUrl()
        {
            return Implementation.getLogoutUrl();
        }

        public static string getUserDisplayName()
        {
            return Implementation.getUserDisplayName();
        }

        public static bool isGuestUser()
        {
            return Implementation.isGuestUser();
        }

        public static bool isInternalUser()
        {
            return Implementation.isInternalUser();
        }
    }
}
