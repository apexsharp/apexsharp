namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UpDownVoteValue
    {
        // infrastructure
        public UpDownVoteValue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UpDownVoteValue));
            }
        }

        // API
        object Down
        {
            get
            {
                return Self.Down;
            }
            set
            {
                Self.Down = value;
            }
        }

        object None
        {
            get
            {
                return Self.None;
            }
            set
            {
                Self.None = value;
            }
        }

        object Up
        {
            get
            {
                return Self.Up;
            }
            set
            {
                Self.Up = value;
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

        public static List<UpDownVoteValue> values()
        {
            return Implementation.values();
        }
    }
}
