namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class OperationType
    {
        // infrastructure
        public OperationType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(OperationType));
            }
        }

        // API
        object Add
        {
            get
            {
                return Self.Add;
            }
            set
            {
                Self.Add = value;
            }
        }

        object Remove
        {
            get
            {
                return Self.Remove;
            }
            set
            {
                Self.Remove = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<OperationType> values()
        {
            return Implementation.values();
        }
    }
}
