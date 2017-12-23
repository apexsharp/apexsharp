namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AppLauncherHelper
    {
        // infrastructure
        public AppLauncherHelper(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AppLauncherHelper));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}
