namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedModifiedInfo
    {
        // infrastructure
        public FeedModifiedInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedModifiedInfo));
            }
        }

        // API
        object isModified
        {
            get
            {
                return Self.isModified;
            }
            set
            {
                Self.isModified = value;
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

        object nextPollUrl
        {
            get
            {
                return Self.nextPollUrl;
            }
            set
            {
                Self.nextPollUrl = value;
            }
        }

        public FeedModifiedInfo()
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
