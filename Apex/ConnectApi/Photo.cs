namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Photo
    {
        // infrastructure
        public Photo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Photo));
            }
        }

        // API
        object fullEmailPhotoUrl
        {
            get
            {
                return Self.fullEmailPhotoUrl;
            }
            set
            {
                Self.fullEmailPhotoUrl = value;
            }
        }

        object largePhotoUrl
        {
            get
            {
                return Self.largePhotoUrl;
            }
            set
            {
                Self.largePhotoUrl = value;
            }
        }

        object mediumPhotoUrl
        {
            get
            {
                return Self.mediumPhotoUrl;
            }
            set
            {
                Self.mediumPhotoUrl = value;
            }
        }

        object photoVersionId
        {
            get
            {
                return Self.photoVersionId;
            }
            set
            {
                Self.photoVersionId = value;
            }
        }

        object smallPhotoUrl
        {
            get
            {
                return Self.smallPhotoUrl;
            }
            set
            {
                Self.smallPhotoUrl = value;
            }
        }

        object standardEmailPhotoUrl
        {
            get
            {
                return Self.standardEmailPhotoUrl;
            }
            set
            {
                Self.standardEmailPhotoUrl = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        public Photo()
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
