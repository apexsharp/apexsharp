namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_double.htm#apex_methods_system_double
    /// </summary>
    public class Double
    {
        // infrastructure
        public Double(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(double));
            }
        }

        // API
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

        public long round()
        {
            return Self.round();
        }

        public static double valueOf(string stringToDouble)
        {
            return Implementation.valueOf(stringToDouble);
        }

        public static double valueOf(object fieldValue)
        {
            return Implementation.valueOf(fieldValue);
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
