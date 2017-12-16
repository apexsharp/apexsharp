namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_UserData.htm#apex_class_Auth_UserData
    /// </summary>
    public class UserData
    {
        // infrastructure
        public UserData(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserData));
            }
        }

        // API
        public UserData(string identifier, string firstName, string lastName, string fullName, string email, string link, string userName, string locale, string provider, string siteLoginUrl, Map<string, string> attributeMap)
        {
            Implementation.Constructor(identifier, firstName, lastName, fullName, email, link, userName, locale, provider, siteLoginUrl, attributeMap);
        }

        string identifier
        {
            get
            {
                return Self.identifier;
            }
            set
            {
                Self.identifier = value;
            }
        }

        string firstName
        {
            get
            {
                return Self.firstName;
            }
            set
            {
                Self.firstName = value;
            }
        }

        string lastName
        {
            get
            {
                return Self.lastName;
            }
            set
            {
                Self.lastName = value;
            }
        }

        string fullName
        {
            get
            {
                return Self.fullName;
            }
            set
            {
                Self.fullName = value;
            }
        }

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

        string link
        {
            get
            {
                return Self.link;
            }
            set
            {
                Self.link = value;
            }
        }

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

        string locale
        {
            get
            {
                return Self.locale;
            }
            set
            {
                Self.locale = value;
            }
        }

        string provider
        {
            get
            {
                return Self.provider;
            }
            set
            {
                Self.provider = value;
            }
        }

        string siteLoginUrl
        {
            get
            {
                return Self.siteLoginUrl;
            }
            set
            {
                Self.siteLoginUrl = value;
            }
        }

        Map<string, string> attributeMap
        {
            get
            {
                return Self.attributeMap;
            }
            set
            {
                Self.attributeMap = value;
            }
        }
    }
}
