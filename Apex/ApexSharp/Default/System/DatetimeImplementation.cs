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
            public static implicit operator Datetime(DatetimeInstance self) => new Datetime(self);

            private dynamic NotImplemented { get; } = new StubImplementation(typeof(Datetime));

            private SysDateTime dateTime;

            private SysDateTime dateTimeGmt => dateTime.ToUniversalTime();

            internal DatetimeInstance(SysDateTime dt) => dateTime = dt;

            internal DatetimeInstance(int year, int month, int day) =>
                dateTime = new SysDateTime(year, month, day);

            internal DatetimeInstance(int year, int month, int day, int hour, int minute, int second, int millisecond) =>
                dateTime = new SysDateTime(year, month, day, hour, minute, second, millisecond);

            public void addError(object msg) => NotImplemented.addError(msg);

            public void addError(object msg, bool escape) => NotImplemented.addError(msg, escape);

            public void addError(string msg) => NotImplemented.addError(msg);

            public void addError(string msg, bool escape) => NotImplemented.addError(msg, escape);

            public Datetime addDays(int days) => new DatetimeInstance(dateTime.AddDays(days));

            public Datetime addHours(int hours) => new DatetimeInstance(dateTime.AddHours(hours));

            public Datetime addMinutes(int minutes) => new DatetimeInstance(dateTime.AddMinutes(minutes));

            public Datetime addMonths(int months) => new DatetimeInstance(dateTime.AddMonths(months));

            public Datetime addSeconds(int seconds) => new DatetimeInstance(dateTime.AddSeconds(seconds));

            public Datetime addYears(int years) => new DatetimeInstance(dateTime.AddYears(years));

            public Date date() => Date.newInstance(dateTime.Year, dateTime.Month, dateTime.Day);

            public Date dateGmt() => Date.newInstance(dateTimeGmt.Year, dateTimeGmt.Month, dateTimeGmt.Day);

            public int day() => dateTime.Day;

            public int dayGmt() => dateTimeGmt.Day;

            public int dayOfYear() => dateTime.DayOfYear;

            public int dayOfYearGmt() => dateTimeGmt.DayOfYear;

            public bool equals(object obj)
            {
                var other = obj as Datetime;
                if (other == null)
                {
                    return false;
                }

                return year() == other.year() && month() == other.month() &&
                    day() == other.day() && hour() == other.hour() && minute() == other.minute() &&
                    second() == other.second() && millisecond() == other.millisecond();
            }

            public int hashCode() => $"{dateTime}".GetHashCode();

            public string format() => NotImplemented.format();

            public string format(string dateformat) => NotImplemented.format(dateformat);

            public string format(string dateformat, string timezone) => NotImplemented.format(dateformat, timezone);

            public string formatGmt(string dateformat) => NotImplemented.formatGmt(dateformat);

            public string formatLong() => NotImplemented.formatLong();

            public long getTime() => NotImplemented.getTime();

            public int hour() => dateTime.Hour;

            public int hourGmt() => dateTimeGmt.Hour;

            public bool isSameDay(Datetime other) => date().isSameDay(other.date());

            public int millisecond() => dateTime.Millisecond;

            public int millisecondGmt() => dateTimeGmt.Millisecond; // doesn't make much sense

            public int minute() => dateTime.Minute;

            public int minuteGmt() => dateTimeGmt.Minute; // doesn't make much sense

            public int month() => dateTime.Month;

            public int monthGmt() => dateTimeGmt.Month;

            public int second() => dateTime.Second;

            public int secondGmt() => dateTimeGmt.Second;

            public Time time() =>
                Time.newInstance(dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond);

            public Time timeGmt() =>
                Time.newInstance(dateTimeGmt.Hour, dateTimeGmt.Minute, dateTimeGmt.Second, dateTimeGmt.Millisecond);

            public string toString() => dateTime.ToString();

            public int year() => dateTime.Year;

            public int yearGmt() => dateTimeGmt.Year;
        }

        // Implementation

        private dynamic NotImplemented { get; } = new StubImplementation(typeof(Datetime));

        public Datetime now() => new DatetimeInstance(SysDateTime.Now);

        public Datetime newInstance(Date date, Time time) =>
            new DatetimeInstance(date.year(), date.month(), date.day(), time.hour(), time.minute(), time.second(), time.millisecond());

        public Datetime newInstance(int year, int month, int day) =>
            new DatetimeInstance(year, month, day);

        public Datetime newInstance(int year, int month, int day, int hour, int minute, int second) =>
            new DatetimeInstance(year, month, day, hour, minute, second, 0);

        public Datetime newInstance(long time) => NotImplemented.newInstance(time);

        public Datetime newInstanceGmt(Date date, Time time) => NotImplemented.newInstanceGmt(date, time);

        public Datetime newInstanceGmt(int year, int month, int day) => NotImplemented.newInstanceGmt(year, month, day);

        public Datetime newInstanceGmt(int year, int month, int day, int hour, int minute, int second) =>
            NotImplemented.newInstanceGmt(year, month, day, hour, minute, second);

        public Datetime parse(string str) => new DatetimeInstance(SysDateTime.Parse(str, CultureInfo.InvariantCulture));

        public SysDateTime ToSystemDateTime(Datetime value) =>
            new SysDateTime(value.year(), value.month(), value.day(), value.hour(), value.minute(), value.second(), value.millisecond());

        public Datetime ToApexDatetime(SysDateTime value) =>
            new DatetimeInstance(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second, value.Millisecond);
    }
}
