namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MediaReference
    {
        // infrastructure
        public MediaReference(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MediaReference));
            }
        }

        // API
        object mediaUrl
        {
            get
            {
                return Self.mediaUrl;
            }
            set
            {
                Self.mediaUrl = value;
            }
        }

        object thumbnailUrl
        {
            get
            {
                return Self.thumbnailUrl;
            }
            set
            {
                Self.thumbnailUrl = value;
            }
        }

        public MediaReference()
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
