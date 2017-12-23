using Apex.ApexSharp.Implementation;
using Apex.System;
using CultureInfo = System.Globalization.CultureInfo;
using SysDateTime = System.DateTime;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Date))]
    public class DateImplementation
    {
        // Self

        public class DateInstance
        {
            public static implicit operator Date(DateInstance self) => new Date(self);

            private dynamic NotImplemented { get; } = new StubImplementation(typeof(Date));

            internal SysDateTime date;

            internal DateInstance(SysDateTime dt) => date = dt;

            internal DateInstance(int year, int month, int day) => date = new SysDateTime(year, month, day);

            public void addError(object msg) => NotImplemented.addError(msg);

            public void addError(object msg, bool escape) => NotImplemented.addError(msg, escape);

            public void addError(string msg) => NotImplemented.addError(msg);

            public void addError(string msg, bool escape) => NotImplemented.addError(msg, escape);

            public Date addDays(int days) => new DateInstance(date.AddDays(days));

            public Date addMonths(int months) => new DateInstance(date.AddMonths(months));

            public Date addYears(int years) => new DateInstance(date.AddYears(years));

            public int day() => date.Day;

            public int dayOfYear() => date.DayOfYear;

            public int daysBetween(Date other) => NotImplemented.daysBetween(other);

            public bool equals(object obj)
            {
                var other = obj as Date;
                if (other == null)
                {
                    return false;
                }

                return year() == other.year() && month() == other.month() && day() == other.day();
            }

            public int hashCode() => $"{date}".GetHashCode();

            public string format() => NotImplemented.format();

            public bool isSameDay(Date other) =>
                year() == other.year() && month() == other.month() && day() == other.day();

            public int month() => date.Month;

            public int monthsBetween(Date other) => NotImplemented.monthsBetween(other);

            public Date toStartOfMonth() => NotImplemented.toStartOfMonth();

            public Date toStartOfWeek() => NotImplemented.toStartOfWeek();

            public string toString() => date.ToString();

            public int year() => date.Year;
        }

        // Implementation

        private dynamic NotImplemented { get; } = new StubImplementation(typeof(Datetime));

        public int daysInMonth(int year, int month) => SysDateTime.DaysInMonth(year, month);

        public bool isLeapYear(int year) => SysDateTime.IsLeapYear(year);

        public Date newInstance(int year, int month, int day) => new DateInstance(year, month, day);

        public Date parse(string str) => new DateInstance(SysDateTime.Parse(str, CultureInfo.InvariantCulture));

        public Date today() => new DateInstance(SysDateTime.Today);

        public Date valueOf(object o) => NotImplemented.valueOf(o);

        public Date valueOf(string str) => NotImplemented.valueOf(str);
    }
}
