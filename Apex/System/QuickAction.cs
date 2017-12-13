using Apex.QuickAction;
using ApexSharpApi.ApexApi;

namespace Apex.System
{
    public class QuickAction
    {
        public static List<DescribeAvailableQuickActionResult> describeAvailableQuickActions(string parentType)
        {
            throw new global::System.NotImplementedException("QuickAction.DescribeAvailableQuickActions");
        }

        public static List<DescribeQuickActionResult> describeQuickActions(List<string> actions)
        {
            throw new global::System.NotImplementedException("QuickAction.DescribeQuickActions");
        }

        public static QuickActionResult performQuickAction(QuickActionRequest performQuickAction)
        {
            throw new global::System.NotImplementedException("QuickAction.PerformQuickAction");
        }

        public static QuickActionResult performQuickAction(QuickActionRequest performQuickAction, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("QuickAction.PerformQuickAction");
        }

        public static List<QuickActionResult> performQuickActions(List<QuickActionRequest> performQuickActions)
        {
            throw new global::System.NotImplementedException("QuickAction.PerformQuickActions");
        }

        public static List<QuickActionResult> performQuickActions(List<QuickActionRequest> performQuickActions,
            bool allOrNothing)
        {
            throw new global::System.NotImplementedException("QuickAction.PerformQuickActions");
        }

        public static QuickActionTemplateResult retrieveQuickActionTemplate(string quickActionName, ID contextId)
        {
            throw new global::System.NotImplementedException("QuickAction.RetrieveQuickActionTemplate");
        }

        public static List<QuickActionTemplateResult> retrieveQuickActionTemplates(List<string> quickActionNames,
            ID contextId)
        {
            throw new global::System.NotImplementedException("QuickAction.RetrieveQuickActionTemplates");
        }
    }
}