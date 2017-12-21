namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_datetime.htm#apex_methods_system_datetime
    /// </summary>
    public class Datetime : global::System.IEquatable<Datetime>
    {
        // infrastructure
        public Datetime(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Datetime));
            }
        }

        // API
        public Datetime addDays(int additionalDays)
        {
            return Self.addDays(additionalDays);
        }

        public Datetime addHours(int additionalHours)
        {
            return Self.addHours(additionalHours);
        }

        public Datetime addMinutes(int additionalMinutes)
        {
            return Self.addMinutes(additionalMinutes);
        }

        public Datetime addMonths(int additionalMonths)
        {
            return Self.addMonths(additionalMonths);
        }

        public Datetime addSeconds(int additionalSeconds)
        {
            return Self.addSeconds(additionalSeconds);
        }

        public Datetime addYears(int additionalYears)
        {
            return Self.addYears(additionalYears);
        }

        public Date date()
        {
            return Self.date();
        }

        public Date dateGMT()
        {
            return Self.dateGMT();
        }

        public int day()
        {
            return Self.day();
        }

        public int dayGmt()
        {
            return Self.dayGmt();
        }

        public int dayOfYear()
        {
            return Self.dayOfYear();
        }

        public int dayOfYearGmt()
        {
            return Self.dayOfYearGmt();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string format()
        {
            return Self.format();
        }

        public string format(string dateFormatString)
        {
            return Self.format(dateFormatString);
        }

        public string format(string dateFormatString, string timezone)
        {
            return Self.format(dateFormatString, timezone);
        }

        public string formatGmt(string dateFormatString)
        {
            return Self.formatGmt(dateFormatString);
        }

        public string formatLong()
        {
            return Self.formatLong();
        }

        public long getTime()
        {
            return Self.getTime();
        }

        public int hour()
        {
            return Self.hour();
        }

        public int hourGmt()
        {
            return Self.hourGmt();
        }

        public bool isSameDay(Datetime dateToCompare)
        {
            return Self.isSameDay(dateToCompare);
        }

        public int millisecond()
        {
            return Self.millisecond();
        }

        public int millisecondGmt()
        {
            return Self.millisecondGmt();
        }

        public int minute()
        {
            return Self.minute();
        }

        public int minuteGmt()
        {
            return Self.minuteGmt();
        }

        public int month()
        {
            return Self.month();
        }

        public int monthGmt()
        {
            return Self.monthGmt();
        }

        public static Datetime newInstance(long milliseconds)
        {
            return Implementation.newInstance(milliseconds);
        }

        public static Datetime newInstance(Date date, Time time)
        {
            return Implementation.newInstance(date, time);
        }

        public static Datetime newInstance(int year, int month, int day)
        {
            return Implementation.newInstance(year, month, day);
        }

        public static Datetime newInstance(int year, int month, int day, int hour, int minute, int second)
        {
            return Implementation.newInstance(year, month, day, hour, minute, second);
        }

        public static Datetime newInstanceGmt(Date date, Time time)
        {
            return Implementation.newInstanceGmt(date, time);
        }

        public static Datetime newInstanceGmt(int year, int month, int date)
        {
            return Implementation.newInstanceGmt(year, month, date);
        }

        public static Datetime newInstanceGmt(int year, int month, int date, int hour, int minute, int second)
        {
            return Implementation.newInstanceGmt(year, month, date, hour, minute, second);
        }

        public static Datetime now()
        {
            return Implementation.now();
        }

        public static Datetime parse(string datetimeString)
        {
            return Implementation.parse(datetimeString);
        }

        public int second()
        {
            return Self.second();
        }

        public int secondGmt()
        {
            return Self.secondGmt();
        }

        public Time time()
        {
            return Self.time();
        }

        public Time timeGmt()
        {
            return Self.timeGmt();
        }

        public string toString()
        {
            return Self.toString();
        }

        public static Datetime valueOf(string dateTimeString)
        {
            return Implementation.valueOf(dateTimeString);
        }

        public static Datetime valueOf(object fieldValue)
        {
            return Implementation.valueOf(fieldValue);
        }

        public static Datetime valueOfGmt(string dateTimeString)
        {
            return Implementation.valueOfGmt(dateTimeString);
        }

        public int year()
        {
            return Self.year();
        }

        public int yearGmt()
        {
            return Self.yearGmt();
        }

        public void addError(Exception msg, bool escape)
        {
            Self.addError(msg, escape);
        }

        public void addError(Exception msg)
        {
            Self.addError(msg);
        }

        public Date dateGmt()
        {
            return Self.dateGmt();
        }

        // interoperability

        public bool Equals(Datetime other) => equals(other);

        public override bool Equals(object obj) => equals(obj);

        public override int GetHashCode() => hashCode();

        public override string ToString() => toString();
    }
}
