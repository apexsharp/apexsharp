namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ExtensionDefinition
    {
        // infrastructure
        public ExtensionDefinition(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ExtensionDefinition));
            }
        }

        // API
        object canAccess
        {
            get
            {
                return Self.canAccess;
            }
            set
            {
                Self.canAccess = value;
            }
        }

        object canCreate
        {
            get
            {
                return Self.canCreate;
            }
            set
            {
                Self.canCreate = value;
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

        object iconUrl
        {
            get
            {
                return Self.iconUrl;
            }
            set
            {
                Self.iconUrl = value;
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

        object informationCollection
        {
            get
            {
                return Self.informationCollection;
            }
            set
            {
                Self.informationCollection = value;
            }
        }

        object isEnabledInCommunity
        {
            get
            {
                return Self.isEnabledInCommunity;
            }
            set
            {
                Self.isEnabledInCommunity = value;
            }
        }

        object isEnabledInLightningPublisher
        {
            get
            {
                return Self.isEnabledInLightningPublisher;
            }
            set
            {
                Self.isEnabledInLightningPublisher = value;
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

        object position
        {
            get
            {
                return Self.position;
            }
            set
            {
                Self.position = value;
            }
        }

        public ExtensionDefinition()
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
