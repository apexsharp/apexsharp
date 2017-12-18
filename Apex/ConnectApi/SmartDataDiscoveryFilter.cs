namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryFilter
    {
        // infrastructure
        public SmartDataDiscoveryFilter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryFilter));
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

        object @operator
        {
            get
            {
                return Self.@operator;
            }
            set
            {
                Self.@operator = value;
            }
        }

        object values
        {
            get
            {
                return Self.values;
            }
            set
            {
                Self.values = value;
            }
        }

        public SmartDataDiscoveryFilter()
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
