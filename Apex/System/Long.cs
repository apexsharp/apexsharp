namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_long.htm#apex_methods_system_long
    /// </summary>
    public class Long
    {
        // infrastructure
        public Long(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(long));
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

        public static long valueOf(string stringToLong)
        {
            return Implementation.valueOf(stringToLong);
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
