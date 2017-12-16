namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PinCapability
    {
        // infrastructure
        public PinCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PinCapability));
            }
        }

        // API
        object isPinnableByMe
        {
            get
            {
                return Self.isPinnableByMe;
            }
            set
            {
                Self.isPinnableByMe = value;
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

        public PinCapability()
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
