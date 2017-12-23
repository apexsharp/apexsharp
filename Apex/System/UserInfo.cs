namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_userinfo.htm#apex_methods_system_userinfo
    /// </summary>
    public class UserInfo
    {
        // infrastructure
        public UserInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserInfo));
            }
        }

        // API
        public static string getDefaultCurrency()
        {
            return Implementation.getDefaultCurrency();
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

        public static string getName()
        {
            return Implementation.getName();
        }

        public static string getOrganizationId()
        {
            return Implementation.getOrganizationId();
        }

        public static string getOrganizationName()
        {
            return Implementation.getOrganizationName();
        }

        public static string getProfileId()
        {
            return Implementation.getProfileId();
        }

        public static string getSessionId()
        {
            return Implementation.getSessionId();
        }

        public static TimeZone getTimeZone()
        {
            return Implementation.getTimeZone();
        }

        public static string getUiTheme()
        {
            return Implementation.getUiTheme();
        }

        public static string getUiThemeDisplayed()
        {
            return Implementation.getUiThemeDisplayed();
        }

        public static string getUserEmail()
        {
            return Implementation.getUserEmail();
        }

        public static string getUserId()
        {
            return Implementation.getUserId();
        }

        public static string getUserName()
        {
            return Implementation.getUserName();
        }

        public static string getUserRoleId()
        {
            return Implementation.getUserRoleId();
        }

        public static string getUserType()
        {
            return Implementation.getUserType();
        }

        public static bool isCurrentUserLicensed(string @namespace)
        {
            return Implementation.isCurrentUserLicensed(@namespace);
        }

        public static bool isMultiCurrencyOrganization()
        {
            return Implementation.isMultiCurrencyOrganization();
        }

        public UserInfo()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
