namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryFilterInput
    {
        // infrastructure
        public SmartDataDiscoveryFilterInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryFilterInput));
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

        object valueList
        {
            get
            {
                return Self.valueList;
            }
            set
            {
                Self.valueList = value;
            }
        }

        public SmartDataDiscoveryFilterInput()
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
