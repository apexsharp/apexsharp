namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChangePasswordController
    {
        // infrastructure
        public ChangePasswordController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChangePasswordController));
            }
        }

        // API
        public static string changePassowrd(string newPassword, string confirmPassword, string oldPassword)
        {
            return Implementation.changePassowrd(newPassword, confirmPassword, oldPassword);
        }

        public static string changePassword(string newPassword, string confirmPassword, string oldPassword, bool shouldRedirect)
        {
            return Implementation.changePassword(newPassword, confirmPassword, oldPassword, shouldRedirect);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static string getPasswordPolicyStatement()
        {
            return Implementation.getPasswordPolicyStatement();
        }
    }
}
