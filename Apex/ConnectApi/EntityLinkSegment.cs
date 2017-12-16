namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EntityLinkSegment
    {
        // infrastructure
        public EntityLinkSegment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EntityLinkSegment));
            }
        }

        // API
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

        object reference
        {
            get
            {
                return Self.reference;
            }
            set
            {
                Self.reference = value;
            }
        }

        public EntityLinkSegment()
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
