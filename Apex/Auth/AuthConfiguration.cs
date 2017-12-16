namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_AuthConfiguration.htm#apex_class_Auth_AuthConfiguration
    /// </summary>
    public class AuthConfiguration
    {
        // infrastructure
        public AuthConfiguration(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AuthConfiguration));
            }
        }

        // API
        public AuthConfiguration(string communityOrCustomUrl, string startUrl)
        {
            Implementation.Constructor(communityOrCustomUrl, startUrl);
        }

        public AuthConfiguration(ID networkId, string startUrl)
        {
            Implementation.Constructor(networkId, startUrl);
        }

        public bool getAllowInternalUserLoginEnabled()
        {
            return Self.getAllowInternalUserLoginEnabled();
        }

        public AuthConfig getAuthConfig()
        {
            return Self.getAuthConfig();
        }

        public List<AuthConfigProviders> getAuthConfigProviders()
        {
            return Self.getAuthConfigProviders();
        }

        public List<AuthProvider> getAuthProviders()
        {
            return Self.getAuthProviders();
        }

        public static string getAuthProviderSsoUrl(string communityUrl, string startUrl, string developerName)
        {
            return Implementation.getAuthProviderSsoUrl(communityUrl, startUrl, developerName);
        }

        public string getBackgroundColor()
        {
            return Self.getBackgroundColor();
        }

        public string getDefaultProfileForRegistration()
        {
            return Self.getDefaultProfileForRegistration();
        }

        public string getFooterText()
        {
            return Self.getFooterText();
        }

        public string getForgotPasswordUrl()
        {
            return Self.getForgotPasswordUrl();
        }

        public string getLogoUrl()
        {
            return Self.getLogoUrl();
        }

        public string getLoginRightFrameUrl()
        {
            return Self.getLoginRightFrameUrl();
        }

        public List<SamlSsoConfig> getSamlProviders()
        {
            return Self.getSamlProviders();
        }

        public static string getSamlSsoUrl(string communityUrl, string startURL, string samlId)
        {
            return Implementation.getSamlSsoUrl(communityUrl, startURL, samlId);
        }

        public bool getSelfRegistrationEnabled()
        {
            return Self.getSelfRegistrationEnabled();
        }

        public string getSelfRegistrationUrl()
        {
            return Self.getSelfRegistrationUrl();
        }

        public string getStartUrl()
        {
            return Self.getStartUrl();
        }

        public bool getUsernamePasswordEnabled()
        {
            return Self.getUsernamePasswordEnabled();
        }

        public bool isCommunityUsingSiteAsContainer()
        {
            return Self.isCommunityUsingSiteAsContainer();
        }

        public string getSamlSSoUrl(string communityOrCustomDomainUrl, string startUrl, string developerName)
        {
            return Self.getSamlSSoUrl(communityOrCustomDomainUrl, startUrl, developerName);
        }
    }
}
