namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UpDownVoteCapability
    {
        // infrastructure
        public UpDownVoteCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UpDownVoteCapability));
            }
        }

        // API
        object downVoteCount
        {
            get
            {
                return Self.downVoteCount;
            }
            set
            {
                Self.downVoteCount = value;
            }
        }

        object myVote
        {
            get
            {
                return Self.myVote;
            }
            set
            {
                Self.myVote = value;
            }
        }

        object upVoteCount
        {
            get
            {
                return Self.upVoteCount;
            }
            set
            {
                Self.upVoteCount = value;
            }
        }

        public UpDownVoteCapability()
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
