namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Zone
    {
        // infrastructure
        public Zone(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Zone));
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

        object isChatterAnswers
        {
            get
            {
                return Self.isChatterAnswers;
            }
            set
            {
                Self.isChatterAnswers = value;
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

        object visibilityId
        {
            get
            {
                return Self.visibilityId;
            }
            set
            {
                Self.visibilityId = value;
            }
        }

        public Zone()
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
