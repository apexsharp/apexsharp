namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ManagedTopicPositionInput
    {
        // infrastructure
        public ManagedTopicPositionInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ManagedTopicPositionInput));
            }
        }

        // API
        object managedTopicId
        {
            get
            {
                return Self.managedTopicId;
            }
            set
            {
                Self.managedTopicId = value;
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

        public ManagedTopicPositionInput()
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
