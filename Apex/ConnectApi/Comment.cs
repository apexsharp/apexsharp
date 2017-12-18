namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Comment
    {
        // infrastructure
        public Comment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Comment));
            }
        }

        // API
        object attachment
        {
            get
            {
                return Self.attachment;
            }
            set
            {
                Self.attachment = value;
            }
        }

        object body
        {
            get
            {
                return Self.body;
            }
            set
            {
                Self.body = value;
            }
        }

        object capabilities
        {
            get
            {
                return Self.capabilities;
            }
            set
            {
                Self.capabilities = value;
            }
        }

        object clientInfo
        {
            get
            {
                return Self.clientInfo;
            }
            set
            {
                Self.clientInfo = value;
            }
        }

        object createdDate
        {
            get
            {
                return Self.createdDate;
            }
            set
            {
                Self.createdDate = value;
            }
        }

        object feedElement
        {
            get
            {
                return Self.feedElement;
            }
            set
            {
                Self.feedElement = value;
            }
        }

        object feedItem
        {
            get
            {
                return Self.feedItem;
            }
            set
            {
                Self.feedItem = value;
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

        object isDeleteRestricted
        {
            get
            {
                return Self.isDeleteRestricted;
            }
            set
            {
                Self.isDeleteRestricted = value;
            }
        }

        object likes
        {
            get
            {
                return Self.likes;
            }
            set
            {
                Self.likes = value;
            }
        }

        object likesMessage
        {
            get
            {
                return Self.likesMessage;
            }
            set
            {
                Self.likesMessage = value;
            }
        }

        object moderationFlags
        {
            get
            {
                return Self.moderationFlags;
            }
            set
            {
                Self.moderationFlags = value;
            }
        }

        object myLike
        {
            get
            {
                return Self.myLike;
            }
            set
            {
                Self.myLike = value;
            }
        }

        object parent
        {
            get
            {
                return Self.parent;
            }
            set
            {
                Self.parent = value;
            }
        }

        object relativeCreatedDate
        {
            get
            {
                return Self.relativeCreatedDate;
            }
            set
            {
                Self.relativeCreatedDate = value;
            }
        }

        object type
        {
            get
            {
                return Self.type;
            }
            set
            {
                Self.type = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        object user
        {
            get
            {
                return Self.user;
            }
            set
            {
                Self.user = value;
            }
        }

        public Comment()
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
