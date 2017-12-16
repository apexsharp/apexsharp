namespace Apex.AppLauncher
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AccountSettingsController
    {
        // infrastructure
        public AccountSettingsController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AccountSettingsController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public static string getCity()
        {
            return Implementation.getCity();
        }

        public static string getCountry()
        {
            return Implementation.getCountry();
        }

        public static List<Map<string, object>> getExtraFields(string extraFieldsFieldSet)
        {
            return Implementation.getExtraFields(extraFieldsFieldSet);
        }

        public static string getFirstName()
        {
            return Implementation.getFirstName();
        }

        public static string getLanguage()
        {
            return Implementation.getLanguage();
        }

        public static string getLastName()
        {
            return Implementation.getLastName();
        }

        public static string getLocale()
        {
            return Implementation.getLocale();
        }

        public static string getMobilePhone()
        {
            return Implementation.getMobilePhone();
        }

        public static string getPostalCode()
        {
            return Implementation.getPostalCode();
        }

        public static string getState()
        {
            return Implementation.getState();
        }

        public static string getStreet()
        {
            return Implementation.getStreet();
        }

        public static string getTimeZone()
        {
            return Implementation.getTimeZone();
        }

        public static string getUserEmail()
        {
            return Implementation.getUserEmail();
        }

        public static string getWorkPhone()
        {
            return Implementation.getWorkPhone();
        }
    }
}
