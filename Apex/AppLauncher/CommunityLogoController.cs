namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_applauncher_CommunityLogoController.htm#apex_class_applauncher_CommunityLogoController
    /// </summary>
    public class CommunityLogoController
    {
        // infrastructure
        public CommunityLogoController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CommunityLogoController));
            }
        }

        // API
        public static string getCommunityName()
        {
            return Implementation.getCommunityName();
        }

        public static string getLogoURL()
        {
            return Implementation.getLogoURL();
        }

        public CommunityLogoController()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
