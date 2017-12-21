namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_time.htm#apex_methods_system_time
    /// </summary>
    public class Time : global::System.IEquatable<Time>
    {
        // infrastructure
        public Time(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Time));
            }
        }

        // API
        public Time addHours(int additionalHours)
        {
            return Self.addHours(additionalHours);
        }

        public Time addMilliseconds(int additionalMilliseconds)
        {
            return Self.addMilliseconds(additionalMilliseconds);
        }

        public Time addMinutes(int additionalMinutes)
        {
            return Self.addMinutes(additionalMinutes);
        }

        public Time addSeconds(int additionalSeconds)
        {
            return Self.addSeconds(additionalSeconds);
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int hour()
        {
            return Self.hour();
        }

        public int millisecond()
        {
            return Self.millisecond();
        }

        public int minute()
        {
            return Self.minute();
        }

        public static Time newInstance(int hour, int minutes, int seconds, int milliseconds)
        {
            return Implementation.newInstance(hour, minutes, seconds, milliseconds);
        }

        public int second()
        {
            return Self.second();
        }

        public void addError(Exception msg, bool escape)
        {
            Self.addError(msg, escape);
        }

        public void addError(Exception msg)
        {
            Self.addError(msg);
        }

        public string toString()
        {
            return Self.toString();
        }

        // interoperability

        public bool Equals(Time other) => equals(other);

        public override bool Equals(object obj) => equals(obj);

        public override int GetHashCode() => hashCode();

        public override string ToString() => toString();
    }
}
