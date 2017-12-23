namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubRepositoryFeatures
    {
        // infrastructure
        public ContentHubRepositoryFeatures(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubRepositoryFeatures));
            }
        }

        // API
        object canBrowse
        {
            get
            {
                return Self.canBrowse;
            }
            set
            {
                Self.canBrowse = value;
            }
        }

        object canSearch
        {
            get
            {
                return Self.canSearch;
            }
            set
            {
                Self.canSearch = value;
            }
        }

        public ContentHubRepositoryFeatures()
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
