namespace Apex.AppLauncher
{
    using ApexSharp.Implementation;
    using System;

    public class AppLauncherDesktopController
    {
        // infrastructure
        public AppLauncherDesktopController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AppLauncherDesktopController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}