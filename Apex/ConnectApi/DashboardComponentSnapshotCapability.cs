namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DashboardComponentSnapshotCapability
    {
        // infrastructure
        public DashboardComponentSnapshotCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DashboardComponentSnapshotCapability));
            }
        }

        // API
        object dashboardComponentSnapshot
        {
            get
            {
                return Self.dashboardComponentSnapshot;
            }
            set
            {
                Self.dashboardComponentSnapshot = value;
            }
        }

        public DashboardComponentSnapshotCapability()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
