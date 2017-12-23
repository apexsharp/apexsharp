namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PinCapabilityInput
    {
        // infrastructure
        public PinCapabilityInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PinCapabilityInput));
            }
        }

        // API
        object entityId
        {
            get
            {
                return Self.entityId;
            }
            set
            {
                Self.entityId = value;
            }
        }

        object isPinned
        {
            get
            {
                return Self.isPinned;
            }
            set
            {
                Self.isPinned = value;
            }
        }

        public PinCapabilityInput()
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
