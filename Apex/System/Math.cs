namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_math.htm#apex_system_methods_math
    /// </summary>
    public class Math
    {
        // infrastructure
        public Math(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Math));
            }
        }

        // API
        public static decimal abs(decimal decimalValue)
        {
            return Implementation.abs(decimalValue);
        }

        public static double abs(double doubleValue)
        {
            return Implementation.abs(doubleValue);
        }

        public static int abs(int integerValue)
        {
            return Implementation.abs(integerValue);
        }

        public static long abs(long longValue)
        {
            return Implementation.abs(longValue);
        }

        public static decimal acos(decimal decimalAngle)
        {
            return Implementation.acos(decimalAngle);
        }

        public static double acos(double doubleAngle)
        {
            return Implementation.acos(doubleAngle);
        }

        public static decimal asin(decimal decimalAngle)
        {
            return Implementation.asin(decimalAngle);
        }

        public static double asin(double doubleAngle)
        {
            return Implementation.asin(doubleAngle);
        }

        public static decimal atan(decimal decimalAngle)
        {
            return Implementation.atan(decimalAngle);
        }

        public static double atan(double doubleAngle)
        {
            return Implementation.atan(doubleAngle);
        }

        public static decimal atan2(decimal xCoordinate, decimal yCoordinate)
        {
            return Implementation.atan2(xCoordinate, yCoordinate);
        }

        public static double atan2(double xCoordinate, double yCoordinate)
        {
            return Implementation.atan2(xCoordinate, yCoordinate);
        }

        public static decimal cbrt(decimal decimalValue)
        {
            return Implementation.cbrt(decimalValue);
        }

        public static double cbrt(double doubleValue)
        {
            return Implementation.cbrt(doubleValue);
        }

        public static decimal ceil(decimal decimalValue)
        {
            return Implementation.ceil(decimalValue);
        }

        public static double ceil(double doubleValue)
        {
            return Implementation.ceil(doubleValue);
        }

        public static decimal cos(decimal decimalAngle)
        {
            return Implementation.cos(decimalAngle);
        }

        public static double cos(double doubleAngle)
        {
            return Implementation.cos(doubleAngle);
        }

        public static decimal cosh(decimal decimalAngle)
        {
            return Implementation.cosh(decimalAngle);
        }

        public static double cosh(double doubleAngle)
        {
            return Implementation.cosh(doubleAngle);
        }

        public static decimal exp(decimal exponentDecimal)
        {
            return Implementation.exp(exponentDecimal);
        }

        public static double exp(double exponentDouble)
        {
            return Implementation.exp(exponentDouble);
        }

        public static decimal floor(decimal decimalValue)
        {
            return Implementation.floor(decimalValue);
        }

        public static double floor(double doubleValue)
        {
            return Implementation.floor(doubleValue);
        }

        public static decimal log(decimal decimalValue)
        {
            return Implementation.log(decimalValue);
        }

        public static double log(double doubleValue)
        {
            return Implementation.log(doubleValue);
        }

        public static decimal log10(decimal decimalValue)
        {
            return Implementation.log10(decimalValue);
        }

        public static double log10(double doubleValue)
        {
            return Implementation.log10(doubleValue);
        }

        public static decimal max(decimal decimalValue1, decimal decimalValue2)
        {
            return Implementation.max(decimalValue1, decimalValue2);
        }

        public static double max(double doubleValue1, double doubleValue2)
        {
            return Implementation.max(doubleValue1, doubleValue2);
        }

        public static int max(int integerValue1, int integerValue2)
        {
            return Implementation.max(integerValue1, integerValue2);
        }

        public static long max(long longValue1, long longValue2)
        {
            return Implementation.max(longValue1, longValue2);
        }

        public static decimal min(decimal decimalValue1, decimal decimalValue2)
        {
            return Implementation.min(decimalValue1, decimalValue2);
        }

        public static double min(double doubleValue1, double doubleValue2)
        {
            return Implementation.min(doubleValue1, doubleValue2);
        }

        public static int min(int integerValue1, int integerValue2)
        {
            return Implementation.min(integerValue1, integerValue2);
        }

        public static long min(long longValue1, long longValue2)
        {
            return Implementation.min(longValue1, longValue2);
        }

        public static int mod(int integerValue1, int integerValue2)
        {
            return Implementation.mod(integerValue1, integerValue2);
        }

        public static long mod(long longValue1, long longValue2)
        {
            return Implementation.mod(longValue1, longValue2);
        }

        public static double pow(double doubleValue, double exponent)
        {
            return Implementation.pow(doubleValue, exponent);
        }

        public static double random()
        {
            return Implementation.random();
        }

        public static decimal rint(decimal decimalValue)
        {
            return Implementation.rint(decimalValue);
        }

        public static double rint(double doubleValue)
        {
            return Implementation.rint(doubleValue);
        }

        public static int round(double doubleValue)
        {
            return Implementation.round(doubleValue);
        }

        public static int round(decimal decimalValue)
        {
            return Implementation.round(decimalValue);
        }

        public static long roundToLong(decimal decimalValue)
        {
            return Implementation.roundToLong(decimalValue);
        }

        public static long roundToLong(double doubleValue)
        {
            return Implementation.roundToLong(doubleValue);
        }

        public static decimal signum(decimal decimalValue)
        {
            return Implementation.signum(decimalValue);
        }

        public static double signum(double doubleValue)
        {
            return Implementation.signum(doubleValue);
        }

        public static decimal sin(decimal decimalAngle)
        {
            return Implementation.sin(decimalAngle);
        }

        public static double sin(double doubleAngle)
        {
            return Implementation.sin(doubleAngle);
        }

        public static decimal sinh(decimal decimalAngle)
        {
            return Implementation.sinh(decimalAngle);
        }

        public static double sinh(double doubleAngle)
        {
            return Implementation.sinh(doubleAngle);
        }

        public static decimal sqrt(decimal decimalValue)
        {
            return Implementation.sqrt(decimalValue);
        }

        public static double sqrt(double doubleValue)
        {
            return Implementation.sqrt(doubleValue);
        }

        public static decimal tan(decimal decimalAngle)
        {
            return Implementation.tan(decimalAngle);
        }

        public static double tan(double doubleAngle)
        {
            return Implementation.tan(doubleAngle);
        }

        public static decimal tanh(decimal decimalAngle)
        {
            return Implementation.tanh(decimalAngle);
        }

        public static double tanh(double doubleAngle)
        {
            return Implementation.tanh(doubleAngle);
        }

        [Final]
        public static double E
        {
            get
            {
                return Implementation.E;
            }
        }

        [Final]
        public static double PI
        {
            get
            {
                return Implementation.PI;
            }
        }
    }
}
