namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class BundleCapability
    {
        // infrastructure
        public BundleCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BundleCapability));
            }
        }

        // API
        object bundleType
        {
            get
            {
                return Self.bundleType;
            }
            set
            {
                Self.bundleType = value;
            }
        }

        object page
        {
            get
            {
                return Self.page;
            }
            set
            {
                Self.page = value;
            }
        }

        object totalElements
        {
            get
            {
                return Self.totalElements;
            }
            set
            {
                Self.totalElements = value;
            }
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
