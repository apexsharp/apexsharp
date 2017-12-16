namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Address
    {
        // infrastructure
        public Address(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Address));
            }
        }

        // API
        object city
        {
            get
            {
                return Self.city;
            }
            set
            {
                Self.city = value;
            }
        }

        object country
        {
            get
            {
                return Self.country;
            }
            set
            {
                Self.country = value;
            }
        }

        object formattedAddress
        {
            get
            {
                return Self.formattedAddress;
            }
            set
            {
                Self.formattedAddress = value;
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

        object street
        {
            get
            {
                return Self.street;
            }
            set
            {
                Self.street = value;
            }
        }

        object zip
        {
            get
            {
                return Self.zip;
            }
            set
            {
                Self.zip = value;
            }
        }

        public Address()
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
