namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class IdentityHeaderController
    {
        // infrastructure
        public IdentityHeaderController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(IdentityHeaderController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public static bool getGuestUser()
        {
            return Implementation.getGuestUser();
        }

        public static bool getInternalUser()
        {
            return Implementation.getInternalUser();
        }

        public static string getLoginUrl()
        {
            return Implementation.getLoginUrl();
        }

        public static string getLogoutUrl()
        {
            return Implementation.getLogoutUrl();
        }

        public static string getPhotoUrl()
        {
            return Implementation.getPhotoUrl();
        }

        public static string getUserDisplayName()
        {
            return Implementation.getUserDisplayName();
        }

        public static string getUserId()
        {
            return Implementation.getUserId();
        }
    }
}
