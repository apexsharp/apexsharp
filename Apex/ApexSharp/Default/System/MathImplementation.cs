using Apex.ApexSharp.Implementation;
using Apex.System;
using Convert = System.Convert;
using SysFun = System.Func<double, double>;
using SysFun2 = System.Func<double, double, double>;
using SysMath = System.Math;
using SysRandom = System.Random;
using static System.Math;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Math))]
    public class MathImplementation
    {
        // Helper functions to apply functions of double arguments to the decimal parameters

        private static decimal Apply(SysFun func, decimal value) =>
            Convert.ToDecimal(func(Convert.ToDouble(value)));

        private static decimal Apply(SysFun2 func, decimal value1, decimal value2) =>
            Convert.ToDecimal(func(Convert.ToDouble(value1), Convert.ToDouble(value2)));

        // Implementation

        public decimal abs(decimal decimalValue) => Abs(decimalValue);

        public double abs(double doubleValue) => Abs(doubleValue);

        public int abs(int integerValue) => Abs(integerValue);

        public long abs(long longValue) => Abs(longValue);

        public decimal acos(decimal decimalAngle) => Apply(Acos, decimalAngle);

        public double acos(double doubleAngle) => Acos(doubleAngle);

        public decimal asin(decimal decimalAngle) => Apply(Asin, decimalAngle);

        public double asin(double doubleAngle) => Asin(doubleAngle);

        public decimal atan(decimal decimalAngle) => Apply(Atan, decimalAngle);

        public double atan(double doubleAngle) => Atan(doubleAngle);

        public decimal atan2(decimal xCoordinate, decimal yCoordinate) => Apply(Atan2, yCoordinate, xCoordinate);

        public double atan2(double xCoordinate, double yCoordinate) => Atan2(yCoordinate, xCoordinate);

        public decimal cbrt(decimal decimalValue) => Apply(Pow, decimalValue, 1m / 3m);

        public double cbrt(double doubleValue) => Pow(doubleValue, 1d / 3d);

        public decimal ceil(decimal decimalValue) => Ceiling(decimalValue);

        public double ceil(double doubleValue) => Ceiling(doubleValue);

        public decimal cos(decimal decimalAngle) => Apply(Cos, decimalAngle);

        public double cos(double doubleAngle) => Cos(doubleAngle);

        public decimal cosh(decimal decimalAngle) => Apply(Cosh, decimalAngle);

        public double cosh(double doubleAngle) => Cosh(doubleAngle);

        public decimal exp(decimal exponentDecimal) => Apply(Exp, exponentDecimal);

        public double exp(double exponentDouble) => Exp(exponentDouble);

        public decimal floor(decimal decimalValue) => Floor(decimalValue);

        public double floor(double doubleValue) => Floor(doubleValue);

        public decimal log(decimal decimalValue) => Apply(Log, decimalValue);

        public double log(double doubleValue) => Log(doubleValue);

        public decimal log10(decimal decimalValue) => Apply(Log10, decimalValue);

        public double log10(double doubleValue) => Log10(doubleValue);

        public decimal max(decimal decimalValue1, decimal decimalValue2) => Max(decimalValue1, decimalValue2);

        public double max(double doubleValue1, double doubleValue2) => Max(doubleValue1, doubleValue2);

        public int max(int integerValue1, int integerValue2) => Max(integerValue1, integerValue2);

        public long max(long longValue1, long longValue2) => Max(longValue1, longValue2);

        public decimal min(decimal decimalValue1, decimal decimalValue2) => Min(decimalValue1, decimalValue2);

        public double min(double doubleValue1, double doubleValue2) => Min(doubleValue1, doubleValue2);

        public int min(int integerValue1, int integerValue2) => Min(integerValue1, integerValue2);

        public long min(long longValue1, long longValue2) => Min(longValue1, longValue2);

        public int mod(int integerValue1, int integerValue2) => integerValue1 % integerValue2;

        public long mod(long longValue1, long longValue2) => longValue1 % longValue2;

        public double pow(double doubleValue, double exponent) => Pow(doubleValue, exponent);

        private SysRandom Random { get; } = new SysRandom();

        public double random() => Random.NextDouble();

        public decimal rint(decimal decimalValue) => Round(decimalValue); // not sure

        public double rint(double doubleValue) => Round(doubleValue); // not sure

        public int round(double doubleValue) => (int)Round(doubleValue);

        public int round(decimal decimalValue) => (int)Round(decimalValue);

        public long roundToLong(decimal decimalValue) => (long)Round(decimalValue);

        public long roundToLong(double doubleValue) => (long)Round(doubleValue);

        public decimal signum(decimal decimalValue) => Sign(decimalValue);

        public double signum(double doubleValue) => Sign(doubleValue);

        public decimal sin(decimal decimalAngle) => Apply(Sin, decimalAngle);

        public double sin(double doubleAngle) => Sin(doubleAngle);

        public decimal sinh(decimal decimalAngle) => Apply(Sinh, decimalAngle);

        public double sinh(double doubleAngle) => Sinh(doubleAngle);

        public decimal sqrt(decimal decimalValue) => Apply(Sqrt, decimalValue);

        public double sqrt(double doubleValue) => Sqrt(doubleValue);

        public decimal tan(decimal decimalAngle) => Apply(Tan, decimalAngle);

        public double tan(double doubleAngle) => Tan(doubleAngle);

        public decimal tanh(decimal decimalAngle) => Apply(Tanh, decimalAngle);

        public double tanh(double doubleAngle) => Tanh(doubleAngle);

        public double E => SysMath.E;

        public double PI => SysMath.PI;
    }
}
