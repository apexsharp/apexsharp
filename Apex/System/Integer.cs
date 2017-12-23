namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_integer.htm#apex_methods_system_integer
    /// </summary>
    public class Integer
    {
        // infrastructure
        public Integer(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(int));
            }
        }

        // API
        public string format()
        {
            return Self.format();
        }

        public static int valueOf(string stringToInteger)
        {
            return Implementation.valueOf(stringToInteger);
        }

        public static int valueOf(object fieldValue)
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
