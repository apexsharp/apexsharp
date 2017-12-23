namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UserOauthInfo
    {
        // infrastructure
        public UserOauthInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserOauthInfo));
            }
        }

        // API
        object availableExternalEmailService
        {
            get
            {
                return Self.availableExternalEmailService;
            }
            set
            {
                Self.availableExternalEmailService = value;
            }
        }

        object isAuthenticated
        {
            get
            {
                return Self.isAuthenticated;
            }
            set
            {
                Self.isAuthenticated = value;
            }
        }

        public UserOauthInfo()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
