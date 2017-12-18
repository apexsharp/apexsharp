namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedItemTopicPage
    {
        // infrastructure
        public FeedItemTopicPage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedItemTopicPage));
            }
        }

        // API
        object canAssignTopics
        {
            get
            {
                return Self.canAssignTopics;
            }
            set
            {
                Self.canAssignTopics = value;
            }
        }

        object topics
        {
            get
            {
                return Self.topics;
            }
            set
            {
                Self.topics = value;
            }
        }

        public FeedItemTopicPage()
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
