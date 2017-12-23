namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class GlobalInfluence
    {
        // infrastructure
        public GlobalInfluence(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(GlobalInfluence));
            }
        }

        // API
        object percentile
        {
            get
            {
                return Self.percentile;
            }
            set
            {
                Self.percentile = value;
            }
        }

        object rank
        {
            get
            {
                return Self.rank;
            }
            set
            {
                Self.rank = value;
            }
        }

        public GlobalInfluence()
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
