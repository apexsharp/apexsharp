namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChatterActivity
    {
        // infrastructure
        public ChatterActivity(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterActivity));
            }
        }

        // API
        object commentCount
        {
            get
            {
                return Self.commentCount;
            }
            set
            {
                Self.commentCount = value;
            }
        }

        object commentReceivedCount
        {
            get
            {
                return Self.commentReceivedCount;
            }
            set
            {
                Self.commentReceivedCount = value;
            }
        }

        object likeReceivedCount
        {
            get
            {
                return Self.likeReceivedCount;
            }
            set
            {
                Self.likeReceivedCount = value;
            }
        }

        object postCount
        {
            get
            {
                return Self.postCount;
            }
            set
            {
                Self.postCount = value;
            }
        }

        public ChatterActivity()
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
