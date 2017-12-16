namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ManagedTopicPositionCollectionInput
    {
        // infrastructure
        public ManagedTopicPositionCollectionInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ManagedTopicPositionCollectionInput));
            }
        }

        // API
        object managedTopicPositions
        {
            get
            {
                return Self.managedTopicPositions;
            }
            set
            {
                Self.managedTopicPositions = value;
            }
        }

        public ManagedTopicPositionCollectionInput()
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
