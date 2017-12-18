namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CommentPage
    {
        // infrastructure
        public CommentPage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CommentPage));
            }
        }

        // API
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

        object total
        {
            get
            {
                return Self.total;
            }
            set
            {
                Self.total = value;
            }
        }

        public CommentPage()
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
