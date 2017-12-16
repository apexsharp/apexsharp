namespace Apex.AppLauncher
{
    using ApexSharp.Implementation;
    using System;

    public class AppLauncherHeaderController
    {
        // infrastructure
        public AppLauncherHeaderController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AppLauncherHeaderController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}