namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_sites.htm#apex_classes_sites
    /// </summary>
    public class Site
    {
        // infrastructure
        public Site(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Site));
            }
        }

        // API
        public static PageReference changePassword(string newPassword, string verifyNewPassword, string oldPassword)
        {
            return Implementation.changePassword(newPassword, verifyNewPassword, oldPassword);
        }

        public static ID createExternalUser(SObject name, string accountId)
        {
            return Implementation.createExternalUser(name, accountId);
        }

        public static ID createExternalUser(SObject name, string accountId, string password)
        {
            return Implementation.createExternalUser(name, accountId, password);
        }

        public static ID createExternalUser(SObject name, string accountId, string password, bool sendEmailConfirmation)
        {
            return Implementation.createExternalUser(name, accountId, password, sendEmailConfirmation);
        }

        public static ID createPersonAccountPortalUser(SObject user, string ownerId, string password)
        {
            return Implementation.createPersonAccountPortalUser(user, ownerId, password);
        }

        public static ID createPersonAccountPortalUser(SObject user, string ownerId, string recordTypeId, string password)
        {
            return Implementation.createPersonAccountPortalUser(user, ownerId, recordTypeId, password);
        }

        public static ID createPortalUser(SObject user, string accountId, string password, bool sendEmailConfirmation)
        {
            return Implementation.createPortalUser(user, accountId, password, sendEmailConfirmation);
        }

        public static bool forgotPassword(string username)
        {
            return Implementation.forgotPassword(username);
        }

        public static string getAdminEmail()
        {
            return Implementation.getAdminEmail();
        }

        public static ID getAdminId()
        {
            return Implementation.getAdminId();
        }

        public static string getAnalyticsTrackingCode()
        {
            return Implementation.getAnalyticsTrackingCode();
        }

        public static string getCurrentSiteUrl()
        {
            return Implementation.getCurrentSiteUrl();
        }

        public static string getBaseCustomUrl()
        {
            return Implementation.getBaseCustomUrl();
        }

        public static string getBaseInsecureUrl()
        {
            return Implementation.getBaseInsecureUrl();
        }

        public static string getBaseRequestUrl()
        {
            return Implementation.getBaseRequestUrl();
        }

        public static string getBaseSecureUrl()
        {
            return Implementation.getBaseSecureUrl();
        }

        public static string getBaseUrl()
        {
            return Implementation.getBaseUrl();
        }

        public static string getCustomWebAddress()
        {
            return Implementation.getCustomWebAddress();
        }

        public static string getDomain()
        {
            return Implementation.getDomain();
        }

        public static string getErrorDescription()
        {
            return Implementation.getErrorDescription();
        }

        public static string getErrorMessage()
        {
            return Implementation.getErrorMessage();
        }

        public static string getExperienceId()
        {
            return Implementation.getExperienceId();
        }

        public static string getMasterLabel()
        {
            return Implementation.getMasterLabel();
        }

        public static string getName()
        {
            return Implementation.getName();
        }

        public static string getOriginalUrl()
        {
            return Implementation.getOriginalUrl();
        }

        public static string getPasswordPolicyStatement()
        {
            return Implementation.getPasswordPolicyStatement();
        }

        public static string getPathPrefix()
        {
            return Implementation.getPathPrefix();
        }

        public static string getPrefix()
        {
            return Implementation.getPrefix();
        }

        public static string getSiteId()
        {
            return Implementation.getSiteId();
        }

        public static PageReference getTemplate()
        {
            return Implementation.getTemplate();
        }

        public static string getSiteType()
        {
            return Implementation.getSiteType();
        }

        public static string getSiteTypeLabel()
        {
            return Implementation.getSiteTypeLabel();
        }

        public static bool isLoginEnabled()
        {
            return Implementation.isLoginEnabled();
        }

        public static bool isPasswordExpired()
        {
            return Implementation.isPasswordExpired();
        }

        public static bool isRegistrationEnabled()
        {
            return Implementation.isRegistrationEnabled();
        }

        public static bool isValidUsername(string username)
        {
            return Implementation.isValidUsername(username);
        }

        public static PageReference login(string username, string password, string startUrl)
        {
            return Implementation.login(username, password, startUrl);
        }

        public static void setExperienceId(string expIdValue)
        {
            Implementation.setExperienceId(expIdValue);
        }

        public static void setPortalUserAsAuthProvider(SObject user, string contactId)
        {
            Implementation.setPortalUserAsAuthProvider(user, contactId);
        }

        public static void validatePassword(SObject user, string password, string confirmPassword)
        {
            Implementation.validatePassword(user, password, confirmPassword);
        }

        [Final]
        string authorization_required
        {
            get
            {
                return Self.authorization_required;
            }
            set
            {
                Self.authorization_required = value;
            }
        }

        [Final]
        string bandwidth_limit_exceeded
        {
            get
            {
                return Self.bandwidth_limit_exceeded;
            }
            set
            {
                Self.bandwidth_limit_exceeded = value;
            }
        }

        [Final]
        string cancel
        {
            get
            {
                return Self.cancel;
            }
            set
            {
                Self.cancel = value;
            }
        }

        [Final]
        string change_password
        {
            get
            {
                return Self.change_password;
            }
            set
            {
                Self.change_password = value;
            }
        }

        [Final]
        string change_your_password
        {
            get
            {
                return Self.change_your_password;
            }
            set
            {
                Self.change_your_password = value;
            }
        }

        [Final]
        string click_forget_password
        {
            get
            {
                return Self.click_forget_password;
            }
            set
            {
                Self.click_forget_password = value;
            }
        }

        [Final]
        string community_nickname
        {
            get
            {
                return Self.community_nickname;
            }
            set
            {
                Self.community_nickname = value;
            }
        }

        [Final]
        string confirm_password
        {
            get
            {
                return Self.confirm_password;
            }
            set
            {
                Self.confirm_password = value;
            }
        }

        [Final]
        string down_for_maintenance
        {
            get
            {
                return Self.down_for_maintenance;
            }
            set
            {
                Self.down_for_maintenance = value;
            }
        }

        [Final]
        string email
        {
            get
            {
                return Self.email;
            }
            set
            {
                Self.email = value;
            }
        }

        [Final]
        string email_is_required
        {
            get
            {
                return Self.email_is_required;
            }
            set
            {
                Self.email_is_required = value;
            }
        }

        [Final]
        string email_us
        {
            get
            {
                return Self.email_us;
            }
            set
            {
                Self.email_us = value;
            }
        }

        [Final]
        string enter_password
        {
            get
            {
                return Self.enter_password;
            }
            set
            {
                Self.enter_password = value;
            }
        }

        [Final]
        string error
        {
            get
            {
                return Self.error;
            }
            set
            {
                Self.error = value;
            }
        }

        [Final]
        string error2
        {
            get
            {
                return Self.error2;
            }
            set
            {
                Self.error2 = value;
            }
        }

        [Final]
        string file_not_found
        {
            get
            {
                return Self.file_not_found;
            }
            set
            {
                Self.file_not_found = value;
            }
        }

        [Final]
        string forgot_password
        {
            get
            {
                return Self.forgot_password;
            }
            set
            {
                Self.forgot_password = value;
            }
        }

        [Final]
        string forgot_password_confirmation
        {
            get
            {
                return Self.forgot_password_confirmation;
            }
            set
            {
                Self.forgot_password_confirmation = value;
            }
        }

        [Final]
        string forgot_your_password_q
        {
            get
            {
                return Self.forgot_your_password_q;
            }
            set
            {
                Self.forgot_your_password_q = value;
            }
        }

        [Final]
        string get_in_touch
        {
            get
            {
                return Self.get_in_touch;
            }
            set
            {
                Self.get_in_touch = value;
            }
        }

        [Final]
        string go_to_login_page
        {
            get
            {
                return Self.go_to_login_page;
            }
            set
            {
                Self.go_to_login_page = value;
            }
        }

        [Final]
        string img_path
        {
            get
            {
                return Self.img_path;
            }
            set
            {
                Self.img_path = value;
            }
        }

        [Final]
        string invalid_email
        {
            get
            {
                return Self.invalid_email;
            }
            set
            {
                Self.invalid_email = value;
            }
        }

        [Final]
        string in_maintenance
        {
            get
            {
                return Self.in_maintenance;
            }
            set
            {
                Self.in_maintenance = value;
            }
        }

        [Final]
        string lastname_is_required
        {
            get
            {
                return Self.lastname_is_required;
            }
            set
            {
                Self.lastname_is_required = value;
            }
        }

        [Final]
        string limit_exceeded
        {
            get
            {
                return Self.limit_exceeded;
            }
            set
            {
                Self.limit_exceeded = value;
            }
        }

        [Final]
        string Login
        {
            get
            {
                return Self.Login;
            }
            set
            {
                Self.Login = value;
            }
        }

        [Final]
        string login_button
        {
            get
            {
                return Self.login_button;
            }
            set
            {
                Self.login_button = value;
            }
        }

        [Final]
        string login_or_register_first
        {
            get
            {
                return Self.login_or_register_first;
            }
            set
            {
                Self.login_or_register_first = value;
            }
        }

        [Final]
        string logout
        {
            get
            {
                return Self.logout;
            }
            set
            {
                Self.logout = value;
            }
        }

        [Final]
        string new_password
        {
            get
            {
                return Self.new_password;
            }
            set
            {
                Self.new_password = value;
            }
        }

        [Final]
        string new_user_q
        {
            get
            {
                return Self.new_user_q;
            }
            set
            {
                Self.new_user_q = value;
            }
        }

        [Final]
        string old_password
        {
            get
            {
                return Self.old_password;
            }
            set
            {
                Self.old_password = value;
            }
        }

        [Final]
        string page_not_found
        {
            get
            {
                return Self.page_not_found;
            }
            set
            {
                Self.page_not_found = value;
            }
        }

        [Final]
        string page_not_found_detail
        {
            get
            {
                return Self.page_not_found_detail;
            }
            set
            {
                Self.page_not_found_detail = value;
            }
        }

        [Final]
        string password
        {
            get
            {
                return Self.password;
            }
            set
            {
                Self.password = value;
            }
        }

        [Final]
        string passwords_dont_match
        {
            get
            {
                return Self.passwords_dont_match;
            }
            set
            {
                Self.passwords_dont_match = value;
            }
        }

        [Final]
        string powered_by
        {
            get
            {
                return Self.powered_by;
            }
            set
            {
                Self.powered_by = value;
            }
        }

        [Final]
        string register
        {
            get
            {
                return Self.register;
            }
            set
            {
                Self.register = value;
            }
        }

        [Final]
        string registration_confirmation
        {
            get
            {
                return Self.registration_confirmation;
            }
            set
            {
                Self.registration_confirmation = value;
            }
        }

        [Final]
        string site_login
        {
            get
            {
                return Self.site_login;
            }
            set
            {
                Self.site_login = value;
            }
        }

        [Final]
        string site_under_construction
        {
            get
            {
                return Self.site_under_construction;
            }
            set
            {
                Self.site_under_construction = value;
            }
        }

        [Final]
        string sorry_for_inconvenience
        {
            get
            {
                return Self.sorry_for_inconvenience;
            }
            set
            {
                Self.sorry_for_inconvenience = value;
            }
        }

        [Final]
        string sorry_for_inconvenience_back_shortly
        {
            get
            {
                return Self.sorry_for_inconvenience_back_shortly;
            }
            set
            {
                Self.sorry_for_inconvenience_back_shortly = value;
            }
        }

        [Final]
        string stay_tuned
        {
            get
            {
                return Self.stay_tuned;
            }
            set
            {
                Self.stay_tuned = value;
            }
        }

        [Final]
        string submit
        {
            get
            {
                return Self.submit;
            }
            set
            {
                Self.submit = value;
            }
        }

        [Final]
        string temp_password_sent
        {
            get
            {
                return Self.temp_password_sent;
            }
            set
            {
                Self.temp_password_sent = value;
            }
        }

        [Final]
        string thank_you_for_registering
        {
            get
            {
                return Self.thank_you_for_registering;
            }
            set
            {
                Self.thank_you_for_registering = value;
            }
        }

        [Final]
        string under_construction
        {
            get
            {
                return Self.under_construction;
            }
            set
            {
                Self.under_construction = value;
            }
        }

        [Final]
        string username
        {
            get
            {
                return Self.username;
            }
            set
            {
                Self.username = value;
            }
        }

        [Final]
        string user_registration
        {
            get
            {
                return Self.user_registration;
            }
            set
            {
                Self.user_registration = value;
            }
        }

        [Final]
        string verify_new_password
        {
            get
            {
                return Self.verify_new_password;
            }
            set
            {
                Self.verify_new_password = value;
            }
        }

        public Site()
        {
            Implementation.Constructor();
        }

        public static PageReference changePassword(string newPassword, string verifyNewPassword)
        {
            return Implementation.changePassword(newPassword, verifyNewPassword);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static ID createPortalUser(SObject user, string accountId)
        {
            return Implementation.createPortalUser(user, accountId);
        }

        public static ID createPortalUser(SObject user, string accountId, string password)
        {
            return Implementation.createPortalUser(user, accountId, password);
        }

        public static bool forgotPassword(string username, string emailTemplateName)
        {
            return Implementation.forgotPassword(username, emailTemplateName);
        }
    }
}
