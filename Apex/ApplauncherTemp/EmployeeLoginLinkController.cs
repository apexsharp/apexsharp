namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_applauncher_EmployeeLoginLinkController.htm#apex_class_applauncher_EmployeeLoginLinkController
    /// </summary>
    public class EmployeeLoginLinkController
    {
        // infrastructure
        public EmployeeLoginLinkController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmployeeLoginLinkController));
            }
        }

        // API
        public static string getEmployeeLoginUrl(string startUrl)
        {
            return Implementation.getEmployeeLoginUrl(startUrl);
        }

        public static bool getIsAllowInternalUserLoginEnabled()
        {
            return Implementation.getIsAllowInternalUserLoginEnabled();
        }

        public EmployeeLoginLinkController()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
