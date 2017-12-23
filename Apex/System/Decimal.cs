namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_decimal.htm#apex_methods_system_decimal
    /// </summary>
    public class Decimal
    {
        // infrastructure
        public Decimal(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(decimal));
            }
        }

        // API
        public decimal abs()
        {
            return Self.abs();
        }

        public decimal divide(decimal divisor, int scale)
        {
            return Self.divide(divisor, scale);
        }

        public decimal divide(decimal divisor, int scale, RoundingMode roundingMode)
        {
            return Self.divide(divisor, scale, roundingMode);
        }

        public double doubleValue()
        {
            return Self.doubleValue();
        }

        public string format()
        {
            return Self.format();
        }

        public int intValue()
        {
            return Self.intValue();
        }

        public long longValue()
        {
            return Self.longValue();
        }

        public decimal pow(int exponent)
        {
            return Self.pow(exponent);
        }

        public int precision()
        {
            return Self.precision();
        }

        public long round()
        {
            return Self.round();
        }

        public long round(RoundingMode roundingMode)
        {
            return Self.round(roundingMode);
        }

        public int scale()
        {
            return Self.scale();
        }

        public decimal setScale(int scale)
        {
            return Self.setScale(scale);
        }

        public decimal setScale(int scale, RoundingMode roundingMode)
        {
            return Self.setScale(scale, roundingMode);
        }

        public decimal stripTrailingZeros()
        {
            return Self.stripTrailingZeros();
        }

        public string toPlainString()
        {
            return Self.toPlainString();
        }

        public static decimal valueOf(double doubleToDecimal)
        {
            return Implementation.valueOf(doubleToDecimal);
        }

        public static decimal valueOf(long longToDecimal)
        {
            return Implementation.valueOf(longToDecimal);
        }

        public static decimal valueOf(string stringToDecimal)
        {
            return Implementation.valueOf(stringToDecimal);
        }

        public void addError(Exception msg, bool escape)
        {
            Self.addError(msg, escape);
        }

        public void addError(Exception msg)
        {
            Self.addError(msg);
        }
    }
}
