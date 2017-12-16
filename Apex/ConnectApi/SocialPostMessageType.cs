namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SocialPostMessageType
    {
        // infrastructure
        public SocialPostMessageType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialPostMessageType));
            }
        }

        // API
        object Comment
        {
            get
            {
                return Self.Comment;
            }
            set
            {
                Self.Comment = value;
            }
        }

        object Direct
        {
            get
            {
                return Self.Direct;
            }
            set
            {
                Self.Direct = value;
            }
        }

        object Post
        {
            get
            {
                return Self.Post;
            }
            set
            {
                Self.Post = value;
            }
        }

        object PrivateMessage
        {
            get
            {
                return Self.PrivateMessage;
            }
            set
            {
                Self.PrivateMessage = value;
            }
        }

        object Reply
        {
            get
            {
                return Self.Reply;
            }
            set
            {
                Self.Reply = value;
            }
        }

        object Retweet
        {
            get
            {
                return Self.Retweet;
            }
            set
            {
                Self.Retweet = value;
            }
        }

        object Tweet
        {
            get
            {
                return Self.Tweet;
            }
            set
            {
                Self.Tweet = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<SocialPostMessageType> values()
        {
            return Implementation.values();
        }
    }
}
