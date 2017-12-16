namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedItemSummary
    {
        // infrastructure
        public FeedItemSummary(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedItemSummary));
            }
        }

        // API
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

        object header
        {
            get
            {
                return Self.header;
            }
            set
            {
                Self.header = value;
            }
        }

        object modifiedDate
        {
            get
            {
                return Self.modifiedDate;
            }
            set
            {
                Self.modifiedDate = value;
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

        public FeedItemSummary()
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
