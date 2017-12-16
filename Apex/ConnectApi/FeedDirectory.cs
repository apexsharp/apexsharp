namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedDirectory
    {
        // infrastructure
        public FeedDirectory(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedDirectory));
            }
        }

        // API
        object favorites
        {
            get
            {
                return Self.favorites;
            }
            set
            {
                Self.favorites = value;
            }
        }

        object feeds
        {
            get
            {
                return Self.feeds;
            }
            set
            {
                Self.feeds = value;
            }
        }

        public FeedDirectory()
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
