namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DirectMessageCapabilityInput
    {
        // infrastructure
        public DirectMessageCapabilityInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DirectMessageCapabilityInput));
            }
        }

        // API
        object membersToAdd
        {
            get
            {
                return Self.membersToAdd;
            }
            set
            {
                Self.membersToAdd = value;
            }
        }

        object membersToRemove
        {
            get
            {
                return Self.membersToRemove;
            }
            set
            {
                Self.membersToRemove = value;
            }
        }

        object subject
        {
            get
            {
                return Self.subject;
            }
            set
            {
                Self.subject = value;
            }
        }

        public DirectMessageCapabilityInput()
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
