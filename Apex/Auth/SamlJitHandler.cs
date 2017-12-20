namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.ConnectApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_Auth_SamlJitHandler.htm#apex_interface_Auth_SamlJitHandler
    /// </summary>
    public interface SamlJitHandler
    {
        User createUser(ID samlSsoProviderId, ID communityId, ID portalId, string federationId, Map<string, string> attributes, string assertion);

        void updateUser(ID userId, ID samlSsoProviderId, ID communityId, ID portalId, string federationId, Map<string, string> attributes, string assertion);
    }
}
