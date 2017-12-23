namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChatterGroup
    {
        // infrastructure
        public ChatterGroup(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterGroup));
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

        object announcement
        {
            get
            {
                return Self.announcement;
            }
            set
            {
                Self.announcement = value;
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

        object canHaveChatterGuests
        {
            get
            {
                return Self.canHaveChatterGuests;
            }
            set
            {
                Self.canHaveChatterGuests = value;
            }
        }

        object community
        {
            get
            {
                return Self.community;
            }
            set
            {
                Self.community = value;
            }
        }

        object description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
            }
        }

        object emailToChatterAddress
        {
            get
            {
                return Self.emailToChatterAddress;
            }
            set
            {
                Self.emailToChatterAddress = value;
            }
        }

        object isArchived
        {
            get
            {
                return Self.isArchived;
            }
            set
            {
                Self.isArchived = value;
            }
        }

        object isAutoArchiveDisabled
        {
            get
            {
                return Self.isAutoArchiveDisabled;
            }
            set
            {
                Self.isAutoArchiveDisabled = value;
            }
        }

        object isBroadcast
        {
            get
            {
                return Self.isBroadcast;
            }
            set
            {
                Self.isBroadcast = value;
            }
        }

        object lastFeedElementPostDate
        {
            get
            {
                return Self.lastFeedElementPostDate;
            }
            set
            {
                Self.lastFeedElementPostDate = value;
            }
        }

        object lastFeedItemPostDate
        {
            get
            {
                return Self.lastFeedItemPostDate;
            }
            set
            {
                Self.lastFeedItemPostDate = value;
            }
        }

        object memberCount
        {
            get
            {
                return Self.memberCount;
            }
            set
            {
                Self.memberCount = value;
            }
        }

        object myRole
        {
            get
            {
                return Self.myRole;
            }
            set
            {
                Self.myRole = value;
            }
        }

        object owner
        {
            get
            {
                return Self.owner;
            }
            set
            {
                Self.owner = value;
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

        object visibility
        {
            get
            {
                return Self.visibility;
            }
            set
            {
                Self.visibility = value;
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
