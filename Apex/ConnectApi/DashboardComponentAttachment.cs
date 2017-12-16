namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DashboardComponentAttachment
    {
        // infrastructure
        public DashboardComponentAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DashboardComponentAttachment));
            }
        }

        // API
        object componentId
        {
            get
            {
                return Self.componentId;
            }
            set
            {
                Self.componentId = value;
            }
        }

        object componentName
        {
            get
            {
                return Self.componentName;
            }
            set
            {
                Self.componentName = value;
            }
        }

        object dashboardBodyText
        {
            get
            {
                return Self.dashboardBodyText;
            }
            set
            {
                Self.dashboardBodyText = value;
            }
        }

        object dashboardId
        {
            get
            {
                return Self.dashboardId;
            }
            set
            {
                Self.dashboardId = value;
            }
        }

        object dashboardName
        {
            get
            {
                return Self.dashboardName;
            }
            set
            {
                Self.dashboardName = value;
            }
        }

        object fullSizeImageUrl
        {
            get
            {
                return Self.fullSizeImageUrl;
            }
            set
            {
                Self.fullSizeImageUrl = value;
            }
        }

        object lastRefreshDate
        {
            get
            {
                return Self.lastRefreshDate;
            }
            set
            {
                Self.lastRefreshDate = value;
            }
        }

        object lastRefreshDateDisplayText
        {
            get
            {
                return Self.lastRefreshDateDisplayText;
            }
            set
            {
                Self.lastRefreshDateDisplayText = value;
            }
        }

        object runningUser
        {
            get
            {
                return Self.runningUser;
            }
            set
            {
                Self.runningUser = value;
            }
        }

        object thumbnailUrl
        {
            get
            {
                return Self.thumbnailUrl;
            }
            set
            {
                Self.thumbnailUrl = value;
            }
        }

        public DashboardComponentAttachment()
        {
            Implementation.Constructor();
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
