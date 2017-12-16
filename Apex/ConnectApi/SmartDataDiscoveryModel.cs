namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryModel
    {
        // infrastructure
        public SmartDataDiscoveryModel(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryModel));
            }
        }

        // API
        object createdBy
        {
            get
            {
                return Self.createdBy;
            }
            set
            {
                Self.createdBy = value;
            }
        }

        object createdDate
        {
            get
            {
                return Self.createdDate;
            }
            set
            {
                Self.createdDate = value;
            }
        }

        object filters
        {
            get
            {
                return Self.filters;
            }
            set
            {
                Self.filters = value;
            }
        }

        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

        object isActive
        {
            get
            {
                return Self.isActive;
            }
            set
            {
                Self.isActive = value;
            }
        }

        object label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        object lastModifiedBy
        {
            get
            {
                return Self.lastModifiedBy;
            }
            set
            {
                Self.lastModifiedBy = value;
            }
        }

        object lastModifiedDate
        {
            get
            {
                return Self.lastModifiedDate;
            }
            set
            {
                Self.lastModifiedDate = value;
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

        object predictionDefinitionUrl
        {
            get
            {
                return Self.predictionDefinitionUrl;
            }
            set
            {
                Self.predictionDefinitionUrl = value;
            }
        }

        object sortOrder
        {
            get
            {
                return Self.sortOrder;
            }
            set
            {
                Self.sortOrder = value;
            }
        }

        object state
        {
            get
            {
                return Self.state;
            }
            set
            {
                Self.state = value;
            }
        }

        object stateVersion
        {
            get
            {
                return Self.stateVersion;
            }
            set
            {
                Self.stateVersion = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        public SmartDataDiscoveryModel()
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
