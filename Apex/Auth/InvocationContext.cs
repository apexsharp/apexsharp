namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_enum_Auth_InvocationContext.htm
    /// </summary>
    public enum InvocationContext
    {
        ASSET_TOKEN,
        OAUTH1,
        OAUTH2_JWT_BEARER_TOKEN,
        OAUTH2_SAML_ASSERTION,
        OAUTH2_SAML_BEARER_ASSERTION,
        OAUTH2_USERNAME_PASSWORD,
        OAUTH2_USER_AGENT_ID_TOKEN,
        OAUTH2_USER_AGENT_TOKEN,
        OAUTH2_WEB_SERVER,
        OPENIDCONNECT,
        REFRESH_TOKEN,
        SAML_ASSERTION,
        UNKNOWN,
        USERID_ENDPOINT
    }
}
