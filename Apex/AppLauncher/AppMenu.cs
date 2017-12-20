namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_applauncher_AppMenu.htm#apex_class_applauncher_AppMenu
    /// </summary>
    public class AppMenu
    {
        // infrastructure
        public AppMenu(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AppMenu));
            }
        }

        // API
        public static void setAppVisibility(ID appMenuItemId, bool isVisible)
        {
            Implementation.setAppVisibility(appMenuItemId, isVisible);
        }

        public static void setOrgSortOrder(List<ID> appIds)
        {
            Implementation.setOrgSortOrder(appIds);
        }

        public static void setUserSortOrder(List<ID> appIds)
        {
            Implementation.setUserSortOrder(appIds);
        }

        public AppMenu()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
