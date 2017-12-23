namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedPollChoice
    {
        // infrastructure
        public FeedPollChoice(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedPollChoice));
            }
        }

        // API
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

        object position
        {
            get
            {
                return Self.position;
            }
            set
            {
                Self.position = value;
            }
        }

        object text
        {
            get
            {
                return Self.text;
            }
            set
            {
                Self.text = value;
            }
        }

        object voteCount
        {
            get
            {
                return Self.voteCount;
            }
            set
            {
                Self.voteCount = value;
            }
        }

        object voteCountRatio
        {
            get
            {
                return Self.voteCountRatio;
            }
            set
            {
                Self.voteCountRatio = value;
            }
        }

        public FeedPollChoice()
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
