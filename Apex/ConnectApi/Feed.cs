namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Feed
    {
        // infrastructure
        public Feed(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Feed));
            }
        }

        // API
        object feedElementPostUrl
        {
            get
            {
                return Self.feedElementPostUrl;
            }
            set
            {
                Self.feedElementPostUrl = value;
            }
        }

        object feedElements
        {
            get
            {
                return Self.feedElements;
            }
            set
            {
                Self.feedElements = value;
            }
        }

        object feedElementsUrl
        {
            get
            {
                return Self.feedElementsUrl;
            }
            set
            {
                Self.feedElementsUrl = value;
            }
        }

        object feedItemsUrl
        {
            get
            {
                return Self.feedItemsUrl;
            }
            set
            {
                Self.feedItemsUrl = value;
            }
        }

        object isModifiedUrl
        {
            get
            {
                return Self.isModifiedUrl;
            }
            set
            {
                Self.isModifiedUrl = value;
            }
        }

        object pinnedFeedElementsUrl
        {
            get
            {
                return Self.pinnedFeedElementsUrl;
            }
            set
            {
                Self.pinnedFeedElementsUrl = value;
            }
        }

        object redirectedFeedType
        {
            get
            {
                return Self.redirectedFeedType;
            }
            set
            {
                Self.redirectedFeedType = value;
            }
        }

        object respectsMute
        {
            get
            {
                return Self.respectsMute;
            }
            set
            {
                Self.respectsMute = value;
            }
        }

        public Feed()
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
