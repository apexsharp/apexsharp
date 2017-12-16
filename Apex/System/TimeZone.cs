namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_timezone.htm#apex_methods_system_timezone
    /// </summary>
    public class TimeZone
    {
        // infrastructure
        public TimeZone(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TimeZone));
            }
        }

        // API
        public string getDisplayName()
        {
            return Self.getDisplayName();
        }

        public string getID()
        {
            return Self.getID();
        }

        public int getOffset(Datetime date)
        {
            return Self.getOffset(date);
        }

        public static TimeZone getTimeZone(string timeZoneIdString)
        {
            return Implementation.getTimeZone(timeZoneIdString);
        }

        public string toString()
        {
            return Self.toString();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
