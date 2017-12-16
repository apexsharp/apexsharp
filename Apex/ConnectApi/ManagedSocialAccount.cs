namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ManagedSocialAccount
    {
        // infrastructure
        public ManagedSocialAccount(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ManagedSocialAccount));
            }
        }

        // API
        object authorizedByUsername
        {
            get
            {
                return Self.authorizedByUsername;
            }
            set
            {
                Self.authorizedByUsername = value;
            }
        }

        object defaultResponseAccountId
        {
            get
            {
                return Self.defaultResponseAccountId;
            }
            set
            {
                Self.defaultResponseAccountId = value;
            }
        }

        object displayName
        {
            get
            {
                return Self.displayName;
            }
            set
            {
                Self.displayName = value;
            }
        }

        object externalPictureUrl
        {
            get
            {
                return Self.externalPictureUrl;
            }
            set
            {
                Self.externalPictureUrl = value;
            }
        }

        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

        object isActive
        {
            get
            {
                return Self.isActive;
            }
            set
            {
                Self.isActive = value;
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

        object label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        object managedAccountId
        {
            get
            {
                return Self.managedAccountId;
            }
            set
            {
                Self.managedAccountId = value;
            }
        }

        object parentProviderUserId
        {
            get
            {
                return Self.parentProviderUserId;
            }
            set
            {
                Self.parentProviderUserId = value;
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

        object providerUserId
        {
            get
            {
                return Self.providerUserId;
            }
            set
            {
                Self.providerUserId = value;
            }
        }

        object socialNetwork
        {
            get
            {
                return Self.socialNetwork;
            }
            set
            {
                Self.socialNetwork = value;
            }
        }

        object uniqueName
        {
            get
            {
                return Self.uniqueName;
            }
            set
            {
                Self.uniqueName = value;
            }
        }

        object username
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

        public ManagedSocialAccount()
        {
            Implementation.Constructor();
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
