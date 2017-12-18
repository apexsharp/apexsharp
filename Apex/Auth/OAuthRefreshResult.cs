namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_OAuthRefreshResult.htm#apex_class_Auth_OAuthRefreshResult
    /// </summary>
    public class OAuthRefreshResult
    {
        // infrastructure
        public OAuthRefreshResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(OAuthRefreshResult));
            }
        }

        // API
        public OAuthRefreshResult(string accessToken, string refreshToken, string error)
        {
            Self = Implementation.Constructor(accessToken, refreshToken, error);
        }

        public OAuthRefreshResult(string accessToken, string refreshToken)
        {
            Self = Implementation.Constructor(accessToken, refreshToken);
        }

        string accessToken
        {
            get
            {
                return Self.accessToken;
            }
            set
            {
                Self.accessToken = value;
            }
        }

        string error
        {
            get
            {
                return Self.error;
            }
            set
            {
                Self.error = value;
            }
        }

        string refreshToken
        {
            get
            {
                return Self.refreshToken;
            }
            set
            {
                Self.refreshToken = value;
            }
        }
    }
}
