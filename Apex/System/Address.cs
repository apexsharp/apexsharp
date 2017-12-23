namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_system_Address.htm#apex_class_system_Address
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
        public string getCity()
        {
            return Self.getCity();
        }

        public string getCountry()
        {
            return Self.getCountry();
        }

        public string getCountryCode()
        {
            return Self.getCountryCode();
        }

        public double getDistance(Location toLocation, string unit)
        {
            return Self.getDistance(toLocation, unit);
        }

        public string getGeocodeAccuracy()
        {
            return Self.getGeocodeAccuracy();
        }

        public double getLatitude()
        {
            return Self.getLatitude();
        }

        public double getLongitude()
        {
            return Self.getLongitude();
        }

        public string getPostalCode()
        {
            return Self.getPostalCode();
        }

        public string getState()
        {
            return Self.getState();
        }

        public string getStateCode()
        {
            return Self.getStateCode();
        }

        public string getStreet()
        {
            return Self.getStreet();
        }

        string city
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

        string country
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

        string countryCode
        {
            get
            {
                return Self.countryCode;
            }
            set
            {
                Self.countryCode = value;
            }
        }

        string geocodeAccuracy
        {
            get
            {
                return Self.geocodeAccuracy;
            }
            set
            {
                Self.geocodeAccuracy = value;
            }
        }

        string postalCode
        {
            get
            {
                return Self.postalCode;
            }
            set
            {
                Self.postalCode = value;
            }
        }

        string state
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

        string stateCode
        {
            get
            {
                return Self.stateCode;
            }
            set
            {
                Self.stateCode = value;
            }
        }

        string street
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

        public Address()
        {
            Self = Implementation.Constructor();
        }
    }
}
