namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentImageFileDetails
    {
        // infrastructure
        public ContentImageFileDetails(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentImageFileDetails));
            }
        }

        // API
        object height
        {
            get
            {
                return Self.height;
            }
            set
            {
                Self.height = value;
            }
        }

        object imageFormat
        {
            get
            {
                return Self.imageFormat;
            }
            set
            {
                Self.imageFormat = value;
            }
        }

        object orientation
        {
            get
            {
                return Self.orientation;
            }
            set
            {
                Self.orientation = value;
            }
        }

        object width
        {
            get
            {
                return Self.width;
            }
            set
            {
                Self.width = value;
            }
        }

        public ContentImageFileDetails()
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
