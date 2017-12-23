namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_AuthToken.htm#apex_class_Auth_AuthToken
    /// </summary>
    public class AuthToken
    {
        // infrastructure
        public AuthToken(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AuthToken));
            }
        }

        // API
        public static string getAccessToken(string authProviderId, string providerName)
        {
            return Implementation.getAccessToken(authProviderId, providerName);
        }

        public static Map<string, string> getAccessTokenMap(string authProviderId, string providerName)
        {
            return Implementation.getAccessTokenMap(authProviderId, providerName);
        }

        public static Map<string, string> refreshAccessToken(string authProviderId, string providerName, string oldAccessToken)
        {
            return Implementation.refreshAccessToken(authProviderId, providerName, oldAccessToken);
        }

        public static bool revokeAccess(string authProviderId, string providerName, string userId, string remoteIdentifier)
        {
            return Implementation.revokeAccess(authProviderId, providerName, userId, remoteIdentifier);
        }
    }
}
