namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AppLauncherSetupReordererController
    {
        // infrastructure
        public AppLauncherSetupReordererController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AppLauncherSetupReordererController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public static Map<string, object> getModel()
        {
            return Implementation.getModel();
        }

        public static string saveOrder(string applicationIds)
        {
            return Implementation.saveOrder(applicationIds);
        }
    }
}
