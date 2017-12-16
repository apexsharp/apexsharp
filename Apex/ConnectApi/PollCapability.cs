namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PollCapability
    {
        // infrastructure
        public PollCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PollCapability));
            }
        }

        // API
        object choices
        {
            get
            {
                return Self.choices;
            }
            set
            {
                Self.choices = value;
            }
        }

        object myChoiceId
        {
            get
            {
                return Self.myChoiceId;
            }
            set
            {
                Self.myChoiceId = value;
            }
        }

        object totalVoteCount
        {
            get
            {
                return Self.totalVoteCount;
            }
            set
            {
                Self.totalVoteCount = value;
            }
        }

        public PollCapability()
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
