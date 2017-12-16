namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.ConnectApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_auth_plugin.htm#apex_auth_plugin
    /// </summary>
    public interface RegistrationHandler
    {
        User createUser(ID portalId, UserData userData);

        void updateUser(ID userId, ID portalId, UserData userData);
    }
}
