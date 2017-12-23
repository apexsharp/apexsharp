namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SocialAccount
    {
        // infrastructure
        public SocialAccount(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialAccount));
            }
        }

        // API
        object externalSocialAccountId
        {
            get
            {
                return Self.externalSocialAccountId;
            }
            set
            {
                Self.externalSocialAccountId = value;
            }
        }

        object handle
        {
            get
            {
                return Self.handle;
            }
            set
            {
                Self.handle = value;
            }
        }

        object name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        object profileUrl
        {
            get
            {
                return Self.profileUrl;
            }
            set
            {
                Self.profileUrl = value;
            }
        }

        object socialPersonaId
        {
            get
            {
                return Self.socialPersonaId;
            }
            set
            {
                Self.socialPersonaId = value;
            }
        }

        public SocialAccount()
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
