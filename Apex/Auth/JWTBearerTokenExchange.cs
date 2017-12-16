namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_JWTBearerTokenExchange.htm#apex_class_Auth_JWTBearerTokenExchange
    /// </summary>
    public class JWTBearerTokenExchange
    {
        // infrastructure
        public JWTBearerTokenExchange(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(JWTBearerTokenExchange));
            }
        }

        // API
        public JWTBearerTokenExchange(string tokenEndpoint, JWS jws)
        {
            Implementation.Constructor(tokenEndpoint, jws);
        }

        public JWTBearerTokenExchange()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getAccessToken()
        {
            return Self.getAccessToken();
        }

        public string getGrantType()
        {
            return Self.getGrantType();
        }

        public HttpResponse getHttpResponse()
        {
            return Self.getHttpResponse();
        }

        public JWS getJWS()
        {
            return Self.getJWS();
        }

        public string getTokenEndpoint()
        {
            return Self.getTokenEndpoint();
        }

        public void setGrantType(string grantType)
        {
            Self.setGrantType(grantType);
        }

        public void setJWS(JWS jws)
        {
            Self.setJWS(jws);
        }

        public void setTokenEndpoint(string tokenEndpoint)
        {
            Self.setTokenEndpoint(tokenEndpoint);
        }
    }
}
