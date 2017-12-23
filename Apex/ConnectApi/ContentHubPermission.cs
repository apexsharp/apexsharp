namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubPermission
    {
        // infrastructure
        public ContentHubPermission(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubPermission));
            }
        }

        // API
        object directoryEntry
        {
            get
            {
                return Self.directoryEntry;
            }
            set
            {
                Self.directoryEntry = value;
            }
        }

        object isUpdatable
        {
            get
            {
                return Self.isUpdatable;
            }
            set
            {
                Self.isUpdatable = value;
            }
        }

        object rights
        {
            get
            {
                return Self.rights;
            }
            set
            {
                Self.rights = value;
            }
        }

        public ContentHubPermission()
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
