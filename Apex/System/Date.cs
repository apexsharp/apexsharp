namespace Apex.System
{
    using SysDateTime = global::System.DateTime;

    public class Date
    {
        internal SysDateTime date;

        internal Date(SysDateTime dt) => date = dt;

        internal Date(int year, int month, int day)
        {
            date = new SysDateTime(year, month, day);
        }

        public Date addDays(int days)
        {
            ////throw new global::System.NotImplementedException("Date.AddDays");
            return new Date(date.AddDays(days));
        }

        public void addError(object msg)
        {
            throw new global::System.NotImplementedException("Date.AddError");
        }

        public void addError(object msg, bool escape)
        {
            throw new global::System.NotImplementedException("Date.AddError");
        }

        public void addError(string msg)
        {
            throw new global::System.NotImplementedException("Date.AddError");
        }

        public void addError(string msg, bool escape)
        {
            throw new global::System.NotImplementedException("Date.AddError");
        }

        public Date addMonths(int months)
        {
            ////throw new global::System.NotImplementedException("Date.AddMonths");
            return new Date(date.AddMonths(months));
        }

        public Date addYears(int years)
        {
            ////throw new global::System.NotImplementedException("Date.AddYears");
            return new Date(date.AddYears(years));
        }

        public int day()
        {
            ////throw new global::System.NotImplementedException("Date.Day");
            return date.Day;
        }

        public int dayOfYear()
        {
            ////throw new global::System.NotImplementedException("Date.DayOfYear");
            return date.DayOfYear;
        }

        public int daysBetween(Date other)
        {
            throw new global::System.NotImplementedException("Date.DaysBetween");
        }

        public static int daysInMonth(int year, int month)
        {
            throw new global::System.NotImplementedException("Date.DaysInMonth");
        }

        public string format()
        {
            throw new global::System.NotImplementedException("Date.Format");
        }

        public static bool isLeapYear(int year)
        {
            throw new global::System.NotImplementedException("Date.IsLeapYear");
        }

        public bool isSameDay(Date other)
        {
            throw new global::System.NotImplementedException("Date.IsSameDay");
        }

        public int month()
        {
            ////throw new global::System.NotImplementedException("Date.Month");
            return date.Month;
        }

        public int monthsBetween(Date other)
        {
            throw new global::System.NotImplementedException("Date.MonthsBetween");
        }

        public static Date newInstance(int year, int month, int day)
        {
            ////throw new global::System.NotImplementedException("Date.NewInstance");
            return new Date(year, month, day);
        }

        public static Date parse(string str)
        {
            ////throw new global::System.NotImplementedException("Date.Parse");
            return new Date(SysDateTime.Parse(str));
        }

        public Date toStartOfMonth()
        {
            throw new global::System.NotImplementedException("Date.ToStartOfMonth");
        }

        public Date toStartOfWeek()
        {
            throw new global::System.NotImplementedException("Date.ToStartOfWeek");
        }

        public static Date today()
        {
            ////throw new global::System.NotImplementedException("Date.Today");
            return new Date(SysDateTime.Today);
        }

        public static Date valueOf(object o)
        {
            throw new global::System.NotImplementedException("Date.ValueOf");
        }

        public static Date valueOf(string str)
        {
            throw new global::System.NotImplementedException("Date.ValueOf");
        }

        public int year()
        {
            ////throw new global::System.NotImplementedException("Date.Year");
            return date.Year;
        }
    }
}