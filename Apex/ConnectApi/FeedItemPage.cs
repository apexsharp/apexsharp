namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedItemPage
    {
        // infrastructure
        public FeedItemPage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedItemPage));
            }
        }

        // API
        object currentPageToken
        {
            get
            {
                return Self.currentPageToken;
            }
            set
            {
                Self.currentPageToken = value;
            }
        }

        object currentPageUrl
        {
            get
            {
                return Self.currentPageUrl;
            }
            set
            {
                Self.currentPageUrl = value;
            }
        }

        object isModifiedToken
        {
            get
            {
                return Self.isModifiedToken;
            }
            set
            {
                Self.isModifiedToken = value;
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

        object items
        {
            get
            {
                return Self.items;
            }
            set
            {
                Self.items = value;
            }
        }

        object nextPageToken
        {
            get
            {
                return Self.nextPageToken;
            }
            set
            {
                Self.nextPageToken = value;
            }
        }

        object nextPageUrl
        {
            get
            {
                return Self.nextPageUrl;
            }
            set
            {
                Self.nextPageUrl = value;
            }
        }

        object updatesToken
        {
            get
            {
                return Self.updatesToken;
            }
            set
            {
                Self.updatesToken = value;
            }
        }

        object updatesUrl
        {
            get
            {
                return Self.updatesUrl;
            }
            set
            {
                Self.updatesUrl = value;
            }
        }

        public FeedItemPage()
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
