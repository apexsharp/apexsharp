namespace Apex.System
{
    using SysDateTime = global::System.DateTime;

    public class DateTime
    {
        private SysDateTime dateTime;

        private SysDateTime dateTimeGmt => dateTime.ToUniversalTime();

        internal DateTime(SysDateTime dt) => dateTime = dt;

        internal DateTime(int year, int month, int day)
        {
            dateTime = new SysDateTime(year, month, day);
        }

        internal DateTime(int year, int month, int day, int hour, int minute, int second)
        {
            dateTime = new SysDateTime(year, month, day, hour, minute, second);
        }

        public static DateTime now()
        {
            return new DateTime(SysDateTime.Now);
        }

        public DateTime addDays(int days)
        {
            ////throw new global::System.NotImplementedException("DateTime.AddDays");
            return new DateTime(dateTime.AddDays(days));
        }

        public void addError(object msg)
        {
            throw new global::System.NotImplementedException("DateTime.AddError");
        }

        public void addError(object msg, bool escape)
        {
            throw new global::System.NotImplementedException("DateTime.AddError");
        }

        public void addError(string msg)
        {
            throw new global::System.NotImplementedException("DateTime.AddError");
        }

        public void addError(string msg, bool escape)
        {
            throw new global::System.NotImplementedException("DateTime.AddError");
        }

        public DateTime addHours(int hours)
        {
            ////throw new global::System.NotImplementedException("DateTime.AddHours");
            return new DateTime(dateTime.AddHours(hours));
        }

        public DateTime addMinutes(int minutes)
        {
            ////throw new global::System.NotImplementedException("DateTime.AddMinutes");
            return new DateTime(dateTime.AddMinutes(minutes));
        }

        public DateTime addMonths(int months)
        {
            ////throw new global::System.NotImplementedException("DateTime.AddMonths");
            return new DateTime(dateTime.AddMonths(months));
        }

        public DateTime addSeconds(int seconds)
        {
            ////throw new global::System.NotImplementedException("DateTime.AddSeconds");
            return new DateTime(dateTime.AddSeconds(seconds));
        }

        public DateTime addYears(int years)
        {
            ////throw new global::System.NotImplementedException("DateTime.AddYears");
            return new DateTime(dateTime.AddYears(years));
        }

        public Date date()
        {
            ////throw new global::System.NotImplementedException("DateTime.Date");
            return new Date(dateTime.Date);
        }

        public Date dateGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.DateGmt");
            return new Date(dateTimeGmt);
        }

        public int day()
        {
            ////throw new global::System.NotImplementedException("DateTime.Day");
            return dateTime.Day;
        }

        public int dayGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.DayGmt");
            return dateTimeGmt.Day;
        }

        public int dayOfYear()
        {
            ////throw new global::System.NotImplementedException("DateTime.DayOfYear");
            return dateTime.DayOfYear;
        }

        public int dayOfYearGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.DayOfYearGmt");
            return dateTimeGmt.DayOfYear;
        }

        public string format()
        {
            throw new global::System.NotImplementedException("DateTime.Format");
        }

        public string format(string dateformat)
        {
            throw new global::System.NotImplementedException("DateTime.Format");
        }

        public string format(string dateformat, string timezone)
        {
            throw new global::System.NotImplementedException("DateTime.Format");
        }

        public string formatGmt(string dateformat)
        {
            throw new global::System.NotImplementedException("DateTime.FormatGmt");
        }

        public string formatLong()
        {
            throw new global::System.NotImplementedException("DateTime.FormatLong");
        }

        public long getTime()
        {
            throw new global::System.NotImplementedException("DateTime.GetTime");
        }

        public int hour()
        {
            ////throw new global::System.NotImplementedException("DateTime.Hour");
            return dateTime.Hour;
        }

        public int hourGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.HourGmt");
            return dateTimeGmt.Hour;
        }

        public bool isSameDay(DateTime other)
        {
            throw new global::System.NotImplementedException("DateTime.IsSameDay");
        }

        public int millisecond()
        {
            ////throw new global::System.NotImplementedException("DateTime.Millisecond");
            return dateTime.Millisecond;
        }

        public int millisecondGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.MillisecondGmt");
            return dateTimeGmt.Millisecond; // doesn't make much sense
        }

        public int minute()
        {
            ////throw new global::System.NotImplementedException("DateTime.Minute");
            return dateTime.Minute;
        }

        public int minuteGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.MinuteGmt");
            return dateTimeGmt.Minute; // doesn't make much sense
        }

        public int month()
        {
            ////throw new global::System.NotImplementedException("DateTime.Month");
            return dateTime.Month;
        }

        public int monthGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.MonthGmt");
            return dateTimeGmt.Month;
        }

        public static DateTime newInstance(Date date, Time time)
        {
            ////throw new global::System.NotImplementedException("DateTime.NewInstance");
            return new DateTime(date.date + time.time);
        }

        public static DateTime newInstance(int year, int month, int day)
        {
            ////throw new global::System.NotImplementedException("DateTime.NewInstance");
            return new DateTime(year, month, day);
        }

        public static DateTime newInstance(int year, int month, int day, int hour, int minute, int second)
        {
            ////throw new global::System.NotImplementedException("DateTime.NewInstance");
            return new DateTime(year, month, day, hour, minute, second);
        }

        public static DateTime newInstance(long time)
        {
            throw new global::System.NotImplementedException("DateTime.NewInstance");
        }

        public static DateTime newInstanceGmt(Date date, Time time)
        {
            throw new global::System.NotImplementedException("DateTime.NewInstanceGmt");
        }

        public static DateTime newInstanceGmt(int year, int month, int day)
        {
            throw new global::System.NotImplementedException("DateTime.NewInstanceGmt");
        }

        public static DateTime newInstanceGmt(int year, int month, int day, int hour, int minute, int second)
        {
            throw new global::System.NotImplementedException("DateTime.NewInstanceGmt");
        }

        public static DateTime parse(string str)
        {
            ////throw new global::System.NotImplementedException("DateTime.Parse");
            return new DateTime(SysDateTime.Parse(str));
        }

        public int second()
        {
            ////throw new global::System.NotImplementedException("DateTime.Second");
            return dateTime.Second;
        }

        public int secondGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.SecondGmt");
            return dateTimeGmt.Second;
        }

        public Time time()
        {
            ////throw new global::System.NotImplementedException("DateTime.Time");
            return new Time(dateTime.TimeOfDay);
        }

        public Time timeGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.TimeGmt");
            return new Time(dateTimeGmt.TimeOfDay);
        }

        public static DateTime valueOf(object o)
        {
            throw new global::System.NotImplementedException("DateTime.ValueOf");
        }

        public static DateTime valueOf(string str)
        {
            throw new global::System.NotImplementedException("DateTime.ValueOf");
        }

        public static DateTime valueOfGmt(string str)
        {
            throw new global::System.NotImplementedException("DateTime.ValueOfGmt");
        }

        public int year()
        {
            ////throw new global::System.NotImplementedException("DateTime.Year");
            return dateTime.Year;
        }

        public int yearGmt()
        {
            ////throw new global::System.NotImplementedException("DateTime.YearGmt");
            return dateTimeGmt.Year;
        }
    }
}