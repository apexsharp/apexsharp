namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_applauncher_LoginFormController.htm#apex_class_applauncher_LoginFormController
    /// </summary>
    public class LoginFormController
    {
        // infrastructure
        public LoginFormController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LoginFormController));
            }
        }

        // API
        public static string getForgotPasswordUrl()
        {
            return Implementation.getForgotPasswordUrl();
        }

        public static bool getIsSelfRegistrationEnabled()
        {
            return Implementation.getIsSelfRegistrationEnabled();
        }

        public static bool getIsUsernamePasswordEnabled()
        {
            return Implementation.getIsUsernamePasswordEnabled();
        }

        public static string getSelfRegistrationUrl()
        {
            return Implementation.getSelfRegistrationUrl();
        }

        public static string login(string username, string password, string startUrl)
        {
            return Implementation.login(username, password, startUrl);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static string getLoginRightFrameUrl()
        {
            return Implementation.getLoginRightFrameUrl();
        }

        public static string setExperienceId(string expId)
        {
            return Implementation.setExperienceId(expId);
        }
    }
}
