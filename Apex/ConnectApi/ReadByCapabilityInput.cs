namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ReadByCapabilityInput
    {
        // infrastructure
        public ReadByCapabilityInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReadByCapabilityInput));
            }
        }

        // API
        object isReadByMe
        {
            get
            {
                return Self.isReadByMe;
            }
            set
            {
                Self.isReadByMe = value;
            }
        }

        object lastReadDateByMe
        {
            get
            {
                return Self.lastReadDateByMe;
            }
            set
            {
                Self.lastReadDateByMe = value;
            }
        }

        public ReadByCapabilityInput()
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
