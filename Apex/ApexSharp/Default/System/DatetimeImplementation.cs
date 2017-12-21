using Apex.ApexSharp.Implementation;
using Apex.System;
using CultureInfo = System.Globalization.CultureInfo;
using SysDateTime = System.DateTime;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Datetime))]
    public class DatetimeImplementation
    {
        // Self

        public class DatetimeInstance
        {
            private SysDateTime dateTime;

            private SysDateTime dateTimeGmt => dateTime.ToUniversalTime();

            private dynamic NotImplemented { get; } = new StubImplementation(typeof(Datetime));

            internal DatetimeInstance(SysDateTime dt) => dateTime = dt;

            internal DatetimeInstance(int year, int month, int day) =>
                dateTime = new SysDateTime(year, month, day);

            internal DatetimeInstance(int year, int month, int day, int hour, int minute, int second) =>
                dateTime = new SysDateTime(year, month, day, hour, minute, second);

            public void addError(object msg) => NotImplemented.addError(msg);

            public void addError(object msg, bool escape) => NotImplemented.addError(msg, escape);

            public void addError(string msg) => NotImplemented.addError(msg);

            public void addError(string msg, bool escape) => NotImplemented.addError(msg, escape);

            public static implicit operator Datetime(DatetimeInstance self) => new Datetime(self);

            public Datetime addDays(int days) => new DatetimeInstance(dateTime.AddDays(days));

            public Datetime addHours(int hours) => new DatetimeInstance(dateTime.AddHours(hours));

            public Datetime addMinutes(int minutes) => new DatetimeInstance(dateTime.AddMinutes(minutes));

            public Datetime addMonths(int months) => new DatetimeInstance(dateTime.AddMonths(months));

            public Datetime addSeconds(int seconds) => new DatetimeInstance(dateTime.AddSeconds(seconds));

            public Datetime addYears(int years) => new DatetimeInstance(dateTime.AddYears(years));

            public Date date() => new Date(dateTime.Date);

            public Date dateGmt() => new Date(dateTimeGmt);

            public int day() => dateTime.Day;

            public int dayGmt() => dateTimeGmt.Day;

            public int dayOfYear() => dateTime.DayOfYear;

            public int dayOfYearGmt() => dateTimeGmt.DayOfYear;

            public string format() => NotImplemented.format();

            public string format(string dateformat) => NotImplemented.format(dateformat);

            public string format(string dateformat, string timezone) => NotImplemented.format(dateformat, timezone);

            public string formatGmt(string dateformat) => NotImplemented.formatGmt(dateformat);

            public string formatLong() => NotImplemented.formatLong();

            public long getTime() => NotImplemented.getTime();

            public int hour() => dateTime.Hour;

            public int hourGmt() => dateTimeGmt.Hour;

            public bool isSameDay(Datetime other) => NotImplemented.isSameDay(other);

            public int millisecond() => dateTime.Millisecond;

            public int millisecondGmt() => dateTimeGmt.Millisecond; // doesn't make much sense

            public int minute() => dateTime.Minute;

            public int minuteGmt() => dateTimeGmt.Minute; // doesn't make much sense

            public int month() => dateTime.Month;

            public int monthGmt() => dateTimeGmt.Month;

            public int second() => dateTime.Second;

            public int secondGmt() => dateTimeGmt.Second;

            public Time time() => new Time(dateTime.TimeOfDay);

            public Time timeGmt() => new Time(dateTimeGmt.TimeOfDay);

            public int year() => dateTime.Year;

            public int yearGmt() => dateTimeGmt.Year;
        }

        // Implementation

        private dynamic NotImplemented { get; } = new StubImplementation(typeof(Datetime));

        public Datetime now() => new DatetimeInstance(SysDateTime.Now);

        public Datetime newInstance(Date date, Time time) =>
            new DatetimeInstance(date.year(), date.month(), date.day(), time.hour(), time.minute(), time.second());

        public Datetime newInstance(int year, int month, int day) =>
            new DatetimeInstance(year, month, day);

        public Datetime newInstance(int year, int month, int day, int hour, int minute, int second) =>
            new DatetimeInstance(year, month, day, hour, minute, second);

        public Datetime newInstance(long time) => NotImplemented.newInstance(time);

        public Datetime newInstanceGmt(Date date, Time time) => NotImplemented.newInstanceGmt(date, time);

        public Datetime newInstanceGmt(int year, int month, int day) => NotImplemented.newInstanceGmt(year, month, day);

        public Datetime newInstanceGmt(int year, int month, int day, int hour, int minute, int second) =>
            NotImplemented.newInstanceGmt(year, month, day, hour, minute, second);

        public Datetime parse(string str) => new DatetimeInstance(SysDateTime.Parse(str, CultureInfo.InvariantCulture));
    }
}
