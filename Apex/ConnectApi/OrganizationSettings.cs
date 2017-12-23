namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class OrganizationSettings
    {
        // infrastructure
        public OrganizationSettings(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(OrganizationSettings));
            }
        }

        // API
        object accessTimeout
        {
            get
            {
                return Self.accessTimeout;
            }
            set
            {
                Self.accessTimeout = value;
            }
        }

        object features
        {
            get
            {
                return Self.features;
            }
            set
            {
                Self.features = value;
            }
        }

        object maintenanceInfo
        {
            get
            {
                return Self.maintenanceInfo;
            }
            set
            {
                Self.maintenanceInfo = value;
            }
        }

        object name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        object orgId
        {
            get
            {
                return Self.orgId;
            }
            set
            {
                Self.orgId = value;
            }
        }

        object userSettings
        {
            get
            {
                return Self.userSettings;
            }
            set
            {
                Self.userSettings = value;
            }
        }

        public OrganizationSettings()
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
