namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_businesshours.htm#apex_classes_businesshours
    /// </summary>
    public class BusinessHours
    {
        // infrastructure
        public BusinessHours(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BusinessHours));
            }
        }

        // API
        public static Datetime add(string businessHoursId, Datetime startDate, long intervalMilliseconds)
        {
            return Implementation.add(businessHoursId, startDate, intervalMilliseconds);
        }

        public static Datetime addGmt(string businessHoursId, Datetime startDate, long intervalMilliseconds)
        {
            return Implementation.addGmt(businessHoursId, startDate, intervalMilliseconds);
        }

        public static long diff(string businessHoursId, Datetime startDate, Datetime endDate)
        {
            return Implementation.diff(businessHoursId, startDate, endDate);
        }

        public static bool isWithin(string businessHoursId, Datetime targetDate)
        {
            return Implementation.isWithin(businessHoursId, targetDate);
        }

        public static Datetime nextStartDate(string businessHoursId, Datetime targetDate)
        {
            return Implementation.nextStartDate(businessHoursId, targetDate);
        }

        public BusinessHours()
        {
            Implementation.Constructor();
        }

        public static Datetime add(ID businessHoursId, Datetime startDate, long interval)
        {
            return Implementation.add(businessHoursId, startDate, interval);
        }

        public static Datetime addGmt(ID businessHoursId, Datetime startDate, long interval)
        {
            return Implementation.addGmt(businessHoursId, startDate, interval);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static Datetime nextStartDate(ID businessHoursId, Datetime targetDate)
        {
            return Implementation.nextStartDate(businessHoursId, targetDate);
        }
    }
}
