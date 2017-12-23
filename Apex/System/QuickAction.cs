namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.QuickAction;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_system_quickaction.htm#apex_class_system_quickaction
    /// </summary>
    public class QuickAction
    {
        // infrastructure
        public QuickAction(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuickAction));
            }
        }

        // API
        public static List<DescribeAvailableQuickActionResult> describeAvailableQuickActions(string parentType)
        {
            return Implementation.describeAvailableQuickActions(parentType);
        }

        public static List<DescribeQuickActionResult> describeAvailableQuickActions(List<string> sObjectNames)
        {
            return Implementation.describeAvailableQuickActions(sObjectNames);
        }

        public static QuickActionResult performQuickAction(QuickActionRequest quickActionRequest)
        {
            return Implementation.performQuickAction(quickActionRequest);
        }

        public static QuickActionResult performQuickAction(QuickActionRequest quickActionRequest, bool allOrNothing)
        {
            return Implementation.performQuickAction(quickActionRequest, allOrNothing);
        }

        public static List<QuickActionResult> performQuickActions(List<QuickActionRequest> quickActionRequests)
        {
            return Implementation.performQuickActions(quickActionRequests);
        }

        public static List<QuickActionResult> performQuickActions(List<QuickActionRequest> quickActionRequests, bool allOrNothing)
        {
            return Implementation.performQuickActions(quickActionRequests, allOrNothing);
        }

        public static List<DescribeQuickActionResult> describeQuickActions(List<string> actions)
        {
            return Implementation.describeQuickActions(actions);
        }

        public static QuickActionTemplateResult retrieveQuickActionTemplate(string quickActionName, ID contextId)
        {
            return Implementation.retrieveQuickActionTemplate(quickActionName, contextId);
        }

        public static List<QuickActionTemplateResult> retrieveQuickActionTemplates(List<string> quickActionNames, ID contextId)
        {
            return Implementation.retrieveQuickActionTemplates(quickActionNames, contextId);
        }
    }
}
