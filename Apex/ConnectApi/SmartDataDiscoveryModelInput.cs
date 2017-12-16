namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryModelInput
    {
        // infrastructure
        public SmartDataDiscoveryModelInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryModelInput));
            }
        }

        // API
        object filterList
        {
            get
            {
                return Self.filterList;
            }
            set
            {
                Self.filterList = value;
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

        public SmartDataDiscoveryModelInput()
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
