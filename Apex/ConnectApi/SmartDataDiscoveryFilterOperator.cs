namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryFilterOperator
    {
        // infrastructure
        public SmartDataDiscoveryFilterOperator(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryFilterOperator));
            }
        }

        // API
        object Between
        {
            get
            {
                return Self.Between;
            }
            set
            {
                Self.Between = value;
            }
        }

        object Contains
        {
            get
            {
                return Self.Contains;
            }
            set
            {
                Self.Contains = value;
            }
        }

        object EndsWith
        {
            get
            {
                return Self.EndsWith;
            }
            set
            {
                Self.EndsWith = value;
            }
        }

        object Equal
        {
            get
            {
                return Self.Equal;
            }
            set
            {
                Self.Equal = value;
            }
        }

        object GreaterThan
        {
            get
            {
                return Self.GreaterThan;
            }
            set
            {
                Self.GreaterThan = value;
            }
        }

        object GreaterThanOrEqual
        {
            get
            {
                return Self.GreaterThanOrEqual;
            }
            set
            {
                Self.GreaterThanOrEqual = value;
            }
        }

        object InSet
        {
            get
            {
                return Self.InSet;
            }
            set
            {
                Self.InSet = value;
            }
        }

        object LessThan
        {
            get
            {
                return Self.LessThan;
            }
            set
            {
                Self.LessThan = value;
            }
        }

        object LessThanOrEqual
        {
            get
            {
                return Self.LessThanOrEqual;
            }
            set
            {
                Self.LessThanOrEqual = value;
            }
        }

        object NotBetween
        {
            get
            {
                return Self.NotBetween;
            }
            set
            {
                Self.NotBetween = value;
            }
        }

        object NotEqual
        {
            get
            {
                return Self.NotEqual;
            }
            set
            {
                Self.NotEqual = value;
            }
        }

        object NotIn
        {
            get
            {
                return Self.NotIn;
            }
            set
            {
                Self.NotIn = value;
            }
        }

        object StartsWith
        {
            get
            {
                return Self.StartsWith;
            }
            set
            {
                Self.StartsWith = value;
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

        public static List<SmartDataDiscoveryFilterOperator> values()
        {
            return Implementation.values();
        }
    }
}
