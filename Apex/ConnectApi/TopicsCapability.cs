namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TopicsCapability
    {
        // infrastructure
        public TopicsCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TopicsCapability));
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

        object items
        {
            get
            {
                return Self.items;
            }
            set
            {
                Self.items = value;
            }
        }

        public TopicsCapability()
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
