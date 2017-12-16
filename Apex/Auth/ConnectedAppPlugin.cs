namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.Dom;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_ConnectedAppPlugin.htm#apex_class_Auth_ConnectedAppPlugin
    /// </summary>
    public class ConnectedAppPlugin
    {
        // infrastructure
        public ConnectedAppPlugin(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ConnectedAppPlugin));
            }
        }

        // API
        public bool authorize(ID userId, ID connectedAppId, bool isAdminApproved)
        {
            return Self.authorize(userId, connectedAppId, isAdminApproved);
        }

        public bool authorize(ID userId, ID connectedAppId, bool isAdminApproved, InvocationContext context)
        {
            return Self.authorize(userId, connectedAppId, isAdminApproved, context);
        }

        public Map<string, string> customAttributes(ID userId, ID connectedAppId, Map<string, string> formulaDefinedAttributes)
        {
            return Self.customAttributes(userId, connectedAppId, formulaDefinedAttributes);
        }

        public Map<string, string> customAttributes(ID userId, ID connectedAppId, Map<string, string> formulaDefinedAttributes, InvocationContext context)
        {
            return Self.customAttributes(userId, connectedAppId, formulaDefinedAttributes, context);
        }

        public XmlNode modifySAMLResponse(Map<string, string> authSession, ID connectedAppId, XmlNode samlResponse)
        {
            return Self.modifySAMLResponse(authSession, connectedAppId, samlResponse);
        }

        public void refresh(ID userId, ID connectedAppId)
        {
            Self.refresh(userId, connectedAppId);
        }

        public void refresh(ID userId, ID connectedAppId, InvocationContext context)
        {
            Self.refresh(userId, connectedAppId, context);
        }
    }
}
