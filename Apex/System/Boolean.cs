namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_boolean.htm#apex_methods_system_boolean
    /// </summary>
    public class Boolean
    {
        // infrastructure
        public Boolean(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(bool));
            }
        }

        // API
        public static bool valueOf(string stringToBoolean)
        {
            return Implementation.valueOf(stringToBoolean);
        }

        public static bool valueOf(object fieldValue)
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
