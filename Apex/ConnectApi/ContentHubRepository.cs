namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubRepository
    {
        // infrastructure
        public ContentHubRepository(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubRepository));
            }
        }

        // API
        object authentication
        {
            get
            {
                return Self.authentication;
            }
            set
            {
                Self.authentication = value;
            }
        }

        object features
        {
            get
            {
                return Self.features;
            }
            set
            {
                Self.features = value;
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

        object providerType
        {
            get
            {
                return Self.providerType;
            }
            set
            {
                Self.providerType = value;
            }
        }

        object rootFolderItemsUrl
        {
            get
            {
                return Self.rootFolderItemsUrl;
            }
            set
            {
                Self.rootFolderItemsUrl = value;
            }
        }

        public ContentHubRepository()
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
