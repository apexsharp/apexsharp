namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SocialPostCapability
    {
        // infrastructure
        public SocialPostCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialPostCapability));
            }
        }

        // API
        object author
        {
            get
            {
                return Self.author;
            }
            set
            {
                Self.author = value;
            }
        }

        object content
        {
            get
            {
                return Self.content;
            }
            set
            {
                Self.content = value;
            }
        }

        object deletedBy
        {
            get
            {
                return Self.deletedBy;
            }
            set
            {
                Self.deletedBy = value;
            }
        }

        object hiddenBy
        {
            get
            {
                return Self.hiddenBy;
            }
            set
            {
                Self.hiddenBy = value;
            }
        }

        object icon
        {
            get
            {
                return Self.icon;
            }
            set
            {
                Self.icon = value;
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

        object isOutbound
        {
            get
            {
                return Self.isOutbound;
            }
            set
            {
                Self.isOutbound = value;
            }
        }

        object likedBy
        {
            get
            {
                return Self.likedBy;
            }
            set
            {
                Self.likedBy = value;
            }
        }

        object messageType
        {
            get
            {
                return Self.messageType;
            }
            set
            {
                Self.messageType = value;
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

        object postUrl
        {
            get
            {
                return Self.postUrl;
            }
            set
            {
                Self.postUrl = value;
            }
        }

        object provider
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

        object recipient
        {
            get
            {
                return Self.recipient;
            }
            set
            {
                Self.recipient = value;
            }
        }

        object recipientId
        {
            get
            {
                return Self.recipientId;
            }
            set
            {
                Self.recipientId = value;
            }
        }

        object reviewScale
        {
            get
            {
                return Self.reviewScale;
            }
            set
            {
                Self.reviewScale = value;
            }
        }

        object reviewScore
        {
            get
            {
                return Self.reviewScore;
            }
            set
            {
                Self.reviewScore = value;
            }
        }

        object status
        {
            get
            {
                return Self.status;
            }
            set
            {
                Self.status = value;
            }
        }

        public SocialPostCapability()
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
