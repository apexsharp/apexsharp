namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_AuthProviderTokenResponse.htm#apex_class_Auth_AuthProviderTokenResponse
    /// </summary>
    public class AuthProviderTokenResponse
    {
        // infrastructure
        public AuthProviderTokenResponse(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AuthProviderTokenResponse));
            }
        }

        // API
        public AuthProviderTokenResponse(string provider, string oauthToken, string oauthSecretOrRefreshToken, string state)
        {
            Self = Implementation.Constructor(provider, oauthToken, oauthSecretOrRefreshToken, state);
        }

        string oauthSecretOrRefreshToken
        {
            get
            {
                return Self.oauthSecretOrRefreshToken;
            }
            set
            {
                Self.oauthSecretOrRefreshToken = value;
            }
        }

        string oauthToken
        {
            get
            {
                return Self.oauthToken;
            }
            set
            {
                Self.oauthToken = value;
            }
        }

        string provider
        {
            get
            {
                return Self.provider;
            }
            set
            {
                Self.provider = value;
            }
        }

        string state
        {
            get
            {
                return Self.state;
            }
            set
            {
                Self.state = value;
            }
        }
    }
}
