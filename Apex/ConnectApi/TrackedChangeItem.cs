namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TrackedChangeItem
    {
        // infrastructure
        public TrackedChangeItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TrackedChangeItem));
            }
        }

        // API
        object fieldName
        {
            get
            {
                return Self.fieldName;
            }
            set
            {
                Self.fieldName = value;
            }
        }

        object newValue
        {
            get
            {
                return Self.newValue;
            }
            set
            {
                Self.newValue = value;
            }
        }

        object oldValue
        {
            get
            {
                return Self.oldValue;
            }
            set
            {
                Self.oldValue = value;
            }
        }

        public TrackedChangeItem()
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
