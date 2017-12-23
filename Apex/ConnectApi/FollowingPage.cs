namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FollowingPage
    {
        // infrastructure
        public FollowingPage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FollowingPage));
            }
        }

        // API
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

        object following
        {
            get
            {
                return Self.following;
            }
            set
            {
                Self.following = value;
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

        object previousPageUrl
        {
            get
            {
                return Self.previousPageUrl;
            }
            set
            {
                Self.previousPageUrl = value;
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

        public FollowingPage()
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
