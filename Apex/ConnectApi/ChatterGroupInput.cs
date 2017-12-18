namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChatterGroupInput
    {
        // infrastructure
        public ChatterGroupInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterGroupInput));
            }
        }

        // API
        object announcement
        {
            get
            {
                return Self.announcement;
            }
            set
            {
                Self.announcement = value;
            }
        }

        object canHaveChatterGuests
        {
            get
            {
                return Self.canHaveChatterGuests;
            }
            set
            {
                Self.canHaveChatterGuests = value;
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

        object information
        {
            get
            {
                return Self.information;
            }
            set
            {
                Self.information = value;
            }
        }

        object isArchived
        {
            get
            {
                return Self.isArchived;
            }
            set
            {
                Self.isArchived = value;
            }
        }

        object isAutoArchiveDisabled
        {
            get
            {
                return Self.isAutoArchiveDisabled;
            }
            set
            {
                Self.isAutoArchiveDisabled = value;
            }
        }

        object isBroadcast
        {
            get
            {
                return Self.isBroadcast;
            }
            set
            {
                Self.isBroadcast = value;
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

        object owner
        {
            get
            {
                return Self.owner;
            }
            set
            {
                Self.owner = value;
            }
        }

        object visibility
        {
            get
            {
                return Self.visibility;
            }
            set
            {
                Self.visibility = value;
            }
        }

        public ChatterGroupInput()
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
