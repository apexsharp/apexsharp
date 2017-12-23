namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RepositoryUserSummary
    {
        // infrastructure
        public RepositoryUserSummary(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RepositoryUserSummary));
            }
        }

        // API
        object firstName
        {
            get
            {
                return Self.firstName;
            }
            set
            {
                Self.firstName = value;
            }
        }

        object lastName
        {
            get
            {
                return Self.lastName;
            }
            set
            {
                Self.lastName = value;
            }
        }

        public RepositoryUserSummary()
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
