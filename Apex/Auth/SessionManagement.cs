namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_SessionManagement.htm#apex_class_Auth_SessionManagement
    /// </summary>
    public class SessionManagement
    {
        // infrastructure
        public SessionManagement(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SessionManagement));
            }
        }

        // API
        public static string generateVerificationUrl(VerificationPolicy policy, string description, string destinationUrl)
        {
            return Implementation.generateVerificationUrl(policy, description, destinationUrl);
        }

        public static Map<string, string> getCurrentSession()
        {
            return Implementation.getCurrentSession();
        }

        public static SessionLevel getRequiredSessionLevelForProfile(string profileId)
        {
            return Implementation.getRequiredSessionLevelForProfile(profileId);
        }

        public static Map<string, string> getQrCode()
        {
            return Implementation.getQrCode();
        }

        public static Map<string, string> ignoreForConcurrentSessionLimit(object sessions)
        {
            return Implementation.ignoreForConcurrentSessionLimit(sessions);
        }

        public static bool inOrgNetworkRange(string ipAddress)
        {
            return Implementation.inOrgNetworkRange(ipAddress);
        }

        public static bool isIpAllowedForProfile(string profileId, string ipAddress)
        {
            return Implementation.isIpAllowedForProfile(profileId, ipAddress);
        }

        public static void setSessionLevel(SessionLevel level)
        {
            Implementation.setSessionLevel(level);
        }

        public static bool validateTotpTokenForKey(string sharedKey, string totpCode)
        {
            return Implementation.validateTotpTokenForKey(sharedKey, totpCode);
        }

        public static bool validateTotpTokenForKey(string totpSharedKey, string totpCode, string description)
        {
            return Implementation.validateTotpTokenForKey(totpSharedKey, totpCode, description);
        }

        public static bool validateTotpTokenForUser(string totpCode)
        {
            return Implementation.validateTotpTokenForUser(totpCode);
        }

        public static bool validateTotpTokenForUser(string totpCode, string description)
        {
            return Implementation.validateTotpTokenForUser(totpCode, description);
        }
    }
}
