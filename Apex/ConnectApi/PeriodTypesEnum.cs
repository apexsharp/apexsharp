namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PeriodTypesEnum
    {
        // infrastructure
        public PeriodTypesEnum(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PeriodTypesEnum));
            }
        }

        // API
        object Month
        {
            get
            {
                return Self.Month;
            }
            set
            {
                Self.Month = value;
            }
        }

        object Quarter
        {
            get
            {
                return Self.Quarter;
            }
            set
            {
                Self.Quarter = value;
            }
        }

        object Week
        {
            get
            {
                return Self.Week;
            }
            set
            {
                Self.Week = value;
            }
        }

        object Year
        {
            get
            {
                return Self.Year;
            }
            set
            {
                Self.Year = value;
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

        public static List<PeriodTypesEnum> values()
        {
            return Implementation.values();
        }
    }
}
