namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_ActionLinks_static_methods.htm#apex_ConnectAPI_ActionLinks_static_methods
    /// </summary>
    public class ActionLinks
    {
        // infrastructure
        public ActionLinks(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActionLinks));
            }
        }

        // API
        public static ActionLinkGroupDefinition createActionLinkGroupDefinition(string communityId, ActionLinkGroupDefinitionInput actionLinkGroup)
        {
            return Implementation.createActionLinkGroupDefinition(communityId, actionLinkGroup);
        }

        public static void deleteActionLinkGroupDefinition(string communityId, string actionLinkGroupId)
        {
            Implementation.deleteActionLinkGroupDefinition(communityId, actionLinkGroupId);
        }

        public static PlatformAction getActionLink(string communityId, string actionLinkId)
        {
            return Implementation.getActionLink(communityId, actionLinkId);
        }

        public static ActionLinkDiagnosticInfo getActionLinkDiagnosticInfo(string communityId, string actionLinkId)
        {
            return Implementation.getActionLinkDiagnosticInfo(communityId, actionLinkId);
        }

        public static PlatformActionGroup getActionLinkGroup(string communityId, string actionLinkGroupId)
        {
            return Implementation.getActionLinkGroup(communityId, actionLinkGroupId);
        }

        public static ActionLinkGroupDefinition getActionLinkGroupDefinition(string communityId, string actionLinkGroupId)
        {
            return Implementation.getActionLinkGroupDefinition(communityId, actionLinkGroupId);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
