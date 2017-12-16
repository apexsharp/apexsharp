namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UserDetail
    {
        // infrastructure
        public UserDetail(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserDetail));
            }
        }

        // API
        object aboutMe
        {
            get
            {
                return Self.aboutMe;
            }
            set
            {
                Self.aboutMe = value;
            }
        }

        object address
        {
            get
            {
                return Self.address;
            }
            set
            {
                Self.address = value;
            }
        }

        object bannerPhoto
        {
            get
            {
                return Self.bannerPhoto;
            }
            set
            {
                Self.bannerPhoto = value;
            }
        }

        object chatterActivity
        {
            get
            {
                return Self.chatterActivity;
            }
            set
            {
                Self.chatterActivity = value;
            }
        }

        object chatterInfluence
        {
            get
            {
                return Self.chatterInfluence;
            }
            set
            {
                Self.chatterInfluence = value;
            }
        }

        object email
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

        object followersCount
        {
            get
            {
                return Self.followersCount;
            }
            set
            {
                Self.followersCount = value;
            }
        }

        object followingCounts
        {
            get
            {
                return Self.followingCounts;
            }
            set
            {
                Self.followingCounts = value;
            }
        }

        object groupCount
        {
            get
            {
                return Self.groupCount;
            }
            set
            {
                Self.groupCount = value;
            }
        }

        object hasChatter
        {
            get
            {
                return Self.hasChatter;
            }
            set
            {
                Self.hasChatter = value;
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

        object managerId
        {
            get
            {
                return Self.managerId;
            }
            set
            {
                Self.managerId = value;
            }
        }

        object managerName
        {
            get
            {
                return Self.managerName;
            }
            set
            {
                Self.managerName = value;
            }
        }

        object phoneNumbers
        {
            get
            {
                return Self.phoneNumbers;
            }
            set
            {
                Self.phoneNumbers = value;
            }
        }

        object thanksReceived
        {
            get
            {
                return Self.thanksReceived;
            }
            set
            {
                Self.thanksReceived = value;
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

        public UserDetail()
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
