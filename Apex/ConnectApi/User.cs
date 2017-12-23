namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class User
    {
        // infrastructure
        public User(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(User));
            }
        }

        // API
        object additionalLabel
        {
            get
            {
                return Self.additionalLabel;
            }
            set
            {
                Self.additionalLabel = value;
            }
        }

        object communityNickname
        {
            get
            {
                return Self.communityNickname;
            }
            set
            {
                Self.communityNickname = value;
            }
        }

        object companyName
        {
            get
            {
                return Self.companyName;
            }
            set
            {
                Self.companyName = value;
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

        object firstName
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

        object isInThisCommunity
        {
            get
            {
                return Self.isInThisCommunity;
            }
            set
            {
                Self.isInThisCommunity = value;
            }
        }

        object lastName
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

        object outOfOffice
        {
            get
            {
                return Self.outOfOffice;
            }
            set
            {
                Self.outOfOffice = value;
            }
        }

        object photo
        {
            get
            {
                return Self.photo;
            }
            set
            {
                Self.photo = value;
            }
        }

        object reputation
        {
            get
            {
                return Self.reputation;
            }
            set
            {
                Self.reputation = value;
            }
        }

        object stamps
        {
            get
            {
                return Self.stamps;
            }
            set
            {
                Self.stamps = value;
            }
        }

        object title
        {
            get
            {
                return Self.title;
            }
            set
            {
                Self.title = value;
            }
        }

        object userType
        {
            get
            {
                return Self.userType;
            }
            set
            {
                Self.userType = value;
            }
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
