namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ReadByCapability
    {
        // infrastructure
        public ReadByCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReadByCapability));
            }
        }

        // API
        object isReadByMe
        {
            get
            {
                return Self.isReadByMe;
            }
            set
            {
                Self.isReadByMe = value;
            }
        }

        object lastReadDateByMe
        {
            get
            {
                return Self.lastReadDateByMe;
            }
            set
            {
                Self.lastReadDateByMe = value;
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

        public ReadByCapability()
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
