namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FollowingCounts
    {
        // infrastructure
        public FollowingCounts(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FollowingCounts));
            }
        }

        // API
        object people
        {
            get
            {
                return Self.people;
            }
            set
            {
                Self.people = value;
            }
        }

        object records
        {
            get
            {
                return Self.records;
            }
            set
            {
                Self.records = value;
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

        public FollowingCounts()
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
