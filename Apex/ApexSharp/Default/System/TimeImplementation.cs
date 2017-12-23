using Apex.ApexSharp.Implementation;
using Apex.System;
using CultureInfo = System.Globalization.CultureInfo;
using TimeSpan = global::System.TimeSpan;
using SysDateTime = System.DateTime;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Time))]
    public class TimeImplementation
    {
        // Self

        public class TimeInstance
        {
            public static implicit operator Time(TimeInstance self) => new Time(self);

            private dynamic NotImplemented { get; } = new StubImplementation(typeof(Time));

            internal TimeSpan time;

            internal TimeInstance(TimeSpan ts) => time = ts;

            public void addError(object msg) => NotImplemented.addError(msg);

            public void addError(object msg, bool escape) => NotImplemented.addError(msg, escape);

            public void addError(string msg) => NotImplemented.addError(msg);

            public void addError(string msg, bool escape) => NotImplemented.addError(msg, escape);

            public Time addHours(int hours) =>
                new TimeInstance(time + TimeSpan.FromHours(hours));

            public Time addMilliseconds(int milliseconds) =>
                new TimeInstance(time + TimeSpan.FromMilliseconds(milliseconds));

            public Time addMinutes(int minutes) =>
                new TimeInstance(time + TimeSpan.FromMinutes(minutes));

            public Time addSeconds(int seconds) =>
                new TimeInstance(time + TimeSpan.FromSeconds(seconds));

            public bool equals(object obj)
            {
                var other = obj as Time;
                if (other == null)
                {
                    return false;
                }

                return hour() == other.hour() && minute() == other.minute() &&
                    second() == other.second() && millisecond() == other.millisecond();
            }

            public int hashCode() => $"{time}".GetHashCode();

            public int hour() => time.Hours;

            public int millisecond() => time.Milliseconds;

            public int minute() => time.Minutes;

            public int second() => time.Seconds;

            public string toString() => time.ToString();
        }

        // Implementation

        public Time newInstance(int hour, int minute, int second, int millisecond) =>
            new TimeInstance(new TimeSpan(hour, minute, second) + TimeSpan.FromMilliseconds(millisecond));
    }
}