namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryOutcomeGoal
    {
        // infrastructure
        public SmartDataDiscoveryOutcomeGoal(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryOutcomeGoal));
            }
        }

        // API
        object Maximize
        {
            get
            {
                return Self.Maximize;
            }
            set
            {
                Self.Maximize = value;
            }
        }

        object Minimize
        {
            get
            {
                return Self.Minimize;
            }
            set
            {
                Self.Minimize = value;
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

        public static List<SmartDataDiscoveryOutcomeGoal> values()
        {
            return Implementation.values();
        }
    }
}
