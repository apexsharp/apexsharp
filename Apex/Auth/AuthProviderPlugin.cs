namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_Auth_AuthProviderPlugin.htm#apex_interface_Auth_AuthProviderPlugin
    /// </summary>
    public interface AuthProviderPlugin
    {
        string getCustomMetadataType();

        UserData getUserInfo(Map<string, string> authProviderConfiguration, AuthProviderTokenResponse response);

        AuthProviderTokenResponse handleCallback(Map<string, string> authProviderConfiguration, AuthProviderCallbackState callbackState);

        PageReference initiate(Map<string, string> authProviderConfiguration, string stateToPropagate);

        OAuthRefreshResult refresh(Map<string, string> authProviderConfiguration, string refreshToken);
    }
}
