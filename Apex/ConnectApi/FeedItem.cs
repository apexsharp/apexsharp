namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedItem
    {
        // infrastructure
        public FeedItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedItem));
            }
        }

        // API
        object actor
        {
            get
            {
                return Self.actor;
            }
            set
            {
                Self.actor = value;
            }
        }

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

        object canShare
        {
            get
            {
                return Self.canShare;
            }
            set
            {
                Self.canShare = value;
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

        object comments
        {
            get
            {
                return Self.comments;
            }
            set
            {
                Self.comments = value;
            }
        }

        object @event
        {
            get
            {
                return Self.@event;
            }
            set
            {
                Self.@event = value;
            }
        }

        object hasVerifiedComment
        {
            get
            {
                return Self.hasVerifiedComment;
            }
            set
            {
                Self.hasVerifiedComment = value;
            }
        }

        object isBookmarkedByCurrentUser
        {
            get
            {
                return Self.isBookmarkedByCurrentUser;
            }
            set
            {
                Self.isBookmarkedByCurrentUser = value;
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

        object isLikedByCurrentUser
        {
            get
            {
                return Self.isLikedByCurrentUser;
            }
            set
            {
                Self.isLikedByCurrentUser = value;
            }
        }

        object isSharable
        {
            get
            {
                return Self.isSharable;
            }
            set
            {
                Self.isSharable = value;
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

        object originalFeedItem
        {
            get
            {
                return Self.originalFeedItem;
            }
            set
            {
                Self.originalFeedItem = value;
            }
        }

        object originalFeedItemActor
        {
            get
            {
                return Self.originalFeedItemActor;
            }
            set
            {
                Self.originalFeedItemActor = value;
            }
        }

        object photoUrl
        {
            get
            {
                return Self.photoUrl;
            }
            set
            {
                Self.photoUrl = value;
            }
        }

        object preamble
        {
            get
            {
                return Self.preamble;
            }
            set
            {
                Self.preamble = value;
            }
        }

        object topics
        {
            get
            {
                return Self.topics;
            }
            set
            {
                Self.topics = value;
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

        public FeedItem()
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
