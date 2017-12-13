namespace Apex.System
{
    using TimeSpan = global::System.TimeSpan;

    public class Time
    {
        internal TimeSpan time;

        internal Time(TimeSpan ts) => time = ts;

        public void addError(object msg)
        {
            throw new global::System.NotImplementedException("Time.AddError");
        }

        public void addError(object msg, bool escape)
        {
            throw new global::System.NotImplementedException("Time.AddError");
        }

        public void addError(string msg)
        {
            throw new global::System.NotImplementedException("Time.AddError");
        }

        public void addError(string msg, bool escape)
        {
            throw new global::System.NotImplementedException("Time.AddError");
        }

        public Time addHours(int hours)
        {
            ////throw new global::System.NotImplementedException("Time.AddHours");
            return new Time(time + TimeSpan.FromHours(hours));
        }

        public Time addMilliseconds(int milliseconds)
        {
            ////throw new global::System.NotImplementedException("Time.AddMilliseconds");
            return new Time(time + TimeSpan.FromMilliseconds(milliseconds));
        }

        public Time addMinutes(int minutes)
        {
            ////throw new global::System.NotImplementedException("Time.AddMinutes");
            return new Time(time + TimeSpan.FromMinutes(minutes));
        }

        public Time addSeconds(int seconds)
        {
            ////throw new global::System.NotImplementedException("Time.AddSeconds");
            return new Time(time + TimeSpan.FromSeconds(seconds));
        }

        public int hour()
        {
            ////throw new global::System.NotImplementedException("Time.Hour");
            return time.Hours;
        }

        public int millisecond()
        {
            ////throw new global::System.NotImplementedException("Time.Millisecond");
            return time.Milliseconds;
        }

        public int minute()
        {
            ////throw new global::System.NotImplementedException("Time.Minute");
            return time.Minutes;
        }

        public static Time newInstance(int hour, int minute, int second, int millisecond)
        {
            ////throw new global::System.NotImplementedException("Time.NewInstance");
            return new Time(new TimeSpan(hour, minute, second) + TimeSpan.FromMilliseconds(millisecond));
        }

        public int second()
        {
            ////throw new global::System.NotImplementedException("Time.Second");
            return time.Seconds;
        }
    }
}