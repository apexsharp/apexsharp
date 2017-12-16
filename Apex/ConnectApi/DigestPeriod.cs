namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DigestPeriod
    {
        // infrastructure
        public DigestPeriod(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DigestPeriod));
            }
        }

        // API
        object DailyDigest
        {
            get
            {
                return Self.DailyDigest;
            }
            set
            {
                Self.DailyDigest = value;
            }
        }

        object WeeklyDigest
        {
            get
            {
                return Self.WeeklyDigest;
            }
            set
            {
                Self.WeeklyDigest = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<DigestPeriod> values()
        {
            return Implementation.values();
        }
    }
}
