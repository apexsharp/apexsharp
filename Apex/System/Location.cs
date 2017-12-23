namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_system_Location.htm#apex_class_system_Location
    /// </summary>
    public class Location
    {
        // infrastructure
        public Location(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Location));
            }
        }

        // API
        public double getDistance(Location toLocation, string unit)
        {
            return Self.getDistance(toLocation, unit);
        }

        public static double getDistance(Location firstLocation, Location secondLocation, string unit)
        {
            return Implementation.getDistance(firstLocation, secondLocation, unit);
        }

        public double getLatitude()
        {
            return Self.getLatitude();
        }

        public double getLongitude()
        {
            return Self.getLongitude();
        }

        public static Location newInstance(decimal latitude, decimal longitude)
        {
            return Implementation.newInstance(latitude, longitude);
        }

        double latitude
        {
            get
            {
                return Self.latitude;
            }
            set
            {
                Self.latitude = value;
            }
        }

        double longitude
        {
            get
            {
                return Self.longitude;
            }
            set
            {
                Self.longitude = value;
            }
        }

        public Location()
        {
            Self = Implementation.Constructor();
        }
    }
}
