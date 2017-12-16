namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Auth;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_applauncher_SocialLoginController.htm#apex_class_applauncher_SocialLoginController
    /// </summary>
    public class SocialLoginController
    {
        // infrastructure
        public SocialLoginController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialLoginController));
            }
        }

        // API
        public static string getSamlSsoUrl(string startUrl, string samlId)
        {
            return Implementation.getSamlSsoUrl(startUrl, samlId);
        }

        public static string getSsoUrl(string startUrl, string developerName)
        {
            return Implementation.getSsoUrl(startUrl, developerName);
        }

        public SocialLoginController()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static List<AuthProvider> getAuthProviders()
        {
            return Implementation.getAuthProviders();
        }

        public static List<SamlSsoConfig> getSamlProviders()
        {
            return Implementation.getSamlProviders();
        }

        public static string handleIdp()
        {
            return Implementation.handleIdp();
        }
    }
}
