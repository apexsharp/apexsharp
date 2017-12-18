namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MaintenanceInfo
    {
        // infrastructure
        public MaintenanceInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MaintenanceInfo));
            }
        }

        // API
        object description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
            }
        }

        object maintenanceTitle
        {
            get
            {
                return Self.maintenanceTitle;
            }
            set
            {
                Self.maintenanceTitle = value;
            }
        }

        object maintenanceType
        {
            get
            {
                return Self.maintenanceType;
            }
            set
            {
                Self.maintenanceType = value;
            }
        }

        object messageEffectiveTime
        {
            get
            {
                return Self.messageEffectiveTime;
            }
            set
            {
                Self.messageEffectiveTime = value;
            }
        }

        object messageExpirationTime
        {
            get
            {
                return Self.messageExpirationTime;
            }
            set
            {
                Self.messageExpirationTime = value;
            }
        }

        object scheduledEndDowntime
        {
            get
            {
                return Self.scheduledEndDowntime;
            }
            set
            {
                Self.scheduledEndDowntime = value;
            }
        }

        object scheduledEndMaintenanceTime
        {
            get
            {
                return Self.scheduledEndMaintenanceTime;
            }
            set
            {
                Self.scheduledEndMaintenanceTime = value;
            }
        }

        object scheduledStartDowntime
        {
            get
            {
                return Self.scheduledStartDowntime;
            }
            set
            {
                Self.scheduledStartDowntime = value;
            }
        }

        object scheduledStartMaintenanceTime
        {
            get
            {
                return Self.scheduledStartMaintenanceTime;
            }
            set
            {
                Self.scheduledStartMaintenanceTime = value;
            }
        }

        public MaintenanceInfo()
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
