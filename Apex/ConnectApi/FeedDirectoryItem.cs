namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedDirectoryItem
    {
        // infrastructure
        public FeedDirectoryItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedDirectoryItem));
            }
        }

        // API
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

        object feedType
        {
            get
            {
                return Self.feedType;
            }
            set
            {
                Self.feedType = value;
            }
        }

        object feedUrl
        {
            get
            {
                return Self.feedUrl;
            }
            set
            {
                Self.feedUrl = value;
            }
        }

        object keyPrefix
        {
            get
            {
                return Self.keyPrefix;
            }
            set
            {
                Self.keyPrefix = value;
            }
        }

        object label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        public FeedDirectoryItem()
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
