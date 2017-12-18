namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedFavorite
    {
        // infrastructure
        public FeedFavorite(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedFavorite));
            }
        }

        // API
        object community
        {
            get
            {
                return Self.community;
            }
            set
            {
                Self.community = value;
            }
        }

        object createdBy
        {
            get
            {
                return Self.createdBy;
            }
            set
            {
                Self.createdBy = value;
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

        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

        object lastViewDate
        {
            get
            {
                return Self.lastViewDate;
            }
            set
            {
                Self.lastViewDate = value;
            }
        }

        object name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        object searchText
        {
            get
            {
                return Self.searchText;
            }
            set
            {
                Self.searchText = value;
            }
        }

        object target
        {
            get
            {
                return Self.target;
            }
            set
            {
                Self.target = value;
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

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        object user
        {
            get
            {
                return Self.user;
            }
            set
            {
                Self.user = value;
            }
        }

        public FeedFavorite()
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
