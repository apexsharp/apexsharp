namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ForgotPasswordController
    {
        // infrastructure
        public ForgotPasswordController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ForgotPasswordController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public static string forgotPassword(string username, string checkEmailUrl)
        {
            return Implementation.forgotPassword(username, checkEmailUrl);
        }

        public static string setExperienceId(string expId)
        {
            return Implementation.setExperienceId(expId);
        }
    }
}
