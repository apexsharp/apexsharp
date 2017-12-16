namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedItemInput
    {
        // infrastructure
        public FeedItemInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedItemInput));
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

        object originalFeedElementId
        {
            get
            {
                return Self.originalFeedElementId;
            }
            set
            {
                Self.originalFeedElementId = value;
            }
        }

        object originalFeedItemId
        {
            get
            {
                return Self.originalFeedItemId;
            }
            set
            {
                Self.originalFeedItemId = value;
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

        public FeedItemInput()
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
