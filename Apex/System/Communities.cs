namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
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
        public Communities()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static PageReference communitiesLanding()
        {
            return Implementation.communitiesLanding();
        }

        public static PageReference communitiesLanding(string startUrl)
        {
            return Implementation.communitiesLanding(startUrl);
        }

        public static PageReference forwardToAuthPage(string startUrl)
        {
            return Implementation.forwardToAuthPage(startUrl);
        }

        public static string getCSS()
        {
            return Implementation.getCSS();
        }

        public static PageReference internalLogin(string startUrl)
        {
            return Implementation.internalLogin(startUrl);
        }

        public static PageReference login(string username, string password, string startUrl)
        {
            return Implementation.login(username, password, startUrl);
        }
    }
}
