namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_AuthProviderCallbackState.htm#apex_class_Auth_AuthProviderCallbackState
    /// </summary>
    public class AuthProviderCallbackState
    {
        // infrastructure
        public AuthProviderCallbackState(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AuthProviderCallbackState));
            }
        }

        // API
        public AuthProviderCallbackState(Map<string, string> headers, string body, Map<string, string> queryParameters)
        {
            Implementation.Constructor(headers, body, queryParameters);
        }

        string body
        {
            get
            {
                return Self.body;
            }
            set
            {
                Self.body = value;
            }
        }

        Map<string, string> headers
        {
            get
            {
                return Self.headers;
            }
            set
            {
                Self.headers = value;
            }
        }

        Map<string, string> queryParameters
        {
            get
            {
                return Self.queryParameters;
            }
            set
            {
                Self.queryParameters = value;
            }
        }
    }
}
