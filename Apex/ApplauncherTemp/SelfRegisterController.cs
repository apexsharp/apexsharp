namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SelfRegisterController
    {
        // infrastructure
        public SelfRegisterController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SelfRegisterController));
            }
        }

        // API
        public SelfRegisterController()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static List<Map<string, object>> getExtraFields(string extraFieldsFieldSet)
        {
            return Implementation.getExtraFields(extraFieldsFieldSet);
        }

        public static bool isValidPassword(string password, string confirmPassword)
        {
            return Implementation.isValidPassword(password, confirmPassword);
        }

        public static string selfRegister(string firstname, string lastname, string email, string password, string confirmPassword, string accountId, string regConfirmUrl, string extraFields, string startUrl, bool includePassword)
        {
            return Implementation.selfRegister(firstname, lastname, email, password, confirmPassword, accountId, regConfirmUrl, extraFields, startUrl, includePassword);
        }

        public static string setExperienceId(string expId)
        {
            return Implementation.setExperienceId(expId);
        }
    }
}
