namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DirectMessageMemberPage
    {
        // infrastructure
        public DirectMessageMemberPage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DirectMessageMemberPage));
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

        object users
        {
            get
            {
                return Self.users;
            }
            set
            {
                Self.users = value;
            }
        }

        public DirectMessageMemberPage()
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
