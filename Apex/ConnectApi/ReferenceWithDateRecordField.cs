namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ReferenceWithDateRecordField
    {
        // infrastructure
        public ReferenceWithDateRecordField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReferenceWithDateRecordField));
            }
        }

        // API
        object dateValue
        {
            get
            {
                return Self.dateValue;
            }
            set
            {
                Self.dateValue = value;
            }
        }

        object reference
        {
            get
            {
                return Self.reference;
            }
            set
            {
                Self.reference = value;
            }
        }

        public ReferenceWithDateRecordField()
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
