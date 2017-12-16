namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Motif
    {
        // infrastructure
        public Motif(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Motif));
            }
        }

        // API
        object color
        {
            get
            {
                return Self.color;
            }
            set
            {
                Self.color = value;
            }
        }

        object largeIconUrl
        {
            get
            {
                return Self.largeIconUrl;
            }
            set
            {
                Self.largeIconUrl = value;
            }
        }

        object mediumIconUrl
        {
            get
            {
                return Self.mediumIconUrl;
            }
            set
            {
                Self.mediumIconUrl = value;
            }
        }

        object smallIconUrl
        {
            get
            {
                return Self.smallIconUrl;
            }
            set
            {
                Self.smallIconUrl = value;
            }
        }

        object svgIconUrl
        {
            get
            {
                return Self.svgIconUrl;
            }
            set
            {
                Self.svgIconUrl = value;
            }
        }

        public Motif()
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
