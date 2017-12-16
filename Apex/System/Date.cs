namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_date.htm#apex_methods_system_date
    /// </summary>
    public class Date
    {
        // infrastructure
        public Date(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Date));
            }
        }

        // API
        public Date addDays(int additionalDays)
        {
            return Self.addDays(additionalDays);
        }

        public Date addMonths(int additionalMonths)
        {
            return Self.addMonths(additionalMonths);
        }

        public Date addYears(int additionalYears)
        {
            return Self.addYears(additionalYears);
        }

        public int day()
        {
            return Self.day();
        }

        public int dayOfYear()
        {
            return Self.dayOfYear();
        }

        public int daysBetween(Date secondDate)
        {
            return Self.daysBetween(secondDate);
        }

        public static int daysInMonth(int year, int month)
        {
            return Implementation.daysInMonth(year, month);
        }

        public string format()
        {
            return Self.format();
        }

        public static bool isLeapYear(int year)
        {
            return Implementation.isLeapYear(year);
        }

        public bool isSameDay(Date dateToCompare)
        {
            return Self.isSameDay(dateToCompare);
        }

        public int month()
        {
            return Self.month();
        }

        public int monthsBetween(Date secondDate)
        {
            return Self.monthsBetween(secondDate);
        }

        public static Date newInstance(int year, int month, int date)
        {
            return Implementation.newInstance(year, month, date);
        }

        public static Date parse(string stringDate)
        {
            return Implementation.parse(stringDate);
        }

        public static Date today()
        {
            return Implementation.today();
        }

        public Date toStartOfMonth()
        {
            return Self.toStartOfMonth();
        }

        public Date toStartOfWeek()
        {
            return Self.toStartOfWeek();
        }

        public static Date valueOf(string stringDate)
        {
            return Implementation.valueOf(stringDate);
        }

        public static Date valueOf(object fieldValue)
        {
            return Implementation.valueOf(fieldValue);
        }

        public int year()
        {
            return Self.year();
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
