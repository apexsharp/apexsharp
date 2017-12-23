namespace Apex.AppLauncher
{
    using ApexSharp.Implementation;
    using System;

    public class AppLauncherSetupTileController
    {
        // infrastructure
        public AppLauncherSetupTileController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AppLauncherSetupTileController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}