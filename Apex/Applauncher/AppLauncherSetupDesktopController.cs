namespace Apex.AppLauncher
{
    using ApexSharp.Implementation;
    using System;

    public class AppLauncherSetupDesktopController
    {
        // infrastructure
        public AppLauncherSetupDesktopController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AppLauncherSetupDesktopController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}