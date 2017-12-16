namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ManagedTopic
    {
        // infrastructure
        public ManagedTopic(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ManagedTopic));
            }
        }

        // API
        object children
        {
            get
            {
                return Self.children;
            }
            set
            {
                Self.children = value;
            }
        }

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

        object managedTopicType
        {
            get
            {
                return Self.managedTopicType;
            }
            set
            {
                Self.managedTopicType = value;
            }
        }

        object parent
        {
            get
            {
                return Self.parent;
            }
            set
            {
                Self.parent = value;
            }
        }

        object topic
        {
            get
            {
                return Self.topic;
            }
            set
            {
                Self.topic = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        public ManagedTopic()
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
