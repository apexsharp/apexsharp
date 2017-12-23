namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TopicsCapabilityInput
    {
        // infrastructure
        public TopicsCapabilityInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TopicsCapabilityInput));
            }
        }

        // API
        object contextTopicName
        {
            get
            {
                return Self.contextTopicName;
            }
            set
            {
                Self.contextTopicName = value;
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

        public TopicsCapabilityInput()
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
