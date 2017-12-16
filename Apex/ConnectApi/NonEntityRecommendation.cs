namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class NonEntityRecommendation
    {
        // infrastructure
        public NonEntityRecommendation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NonEntityRecommendation));
            }
        }

        // API
        object displayLabel
        {
            get
            {
                return Self.displayLabel;
            }
            set
            {
                Self.displayLabel = value;
            }
        }

        object motif
        {
            get
            {
                return Self.motif;
            }
            set
            {
                Self.motif = value;
            }
        }

        public NonEntityRecommendation()
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
