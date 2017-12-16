namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InlineImageSegment
    {
        // infrastructure
        public InlineImageSegment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InlineImageSegment));
            }
        }

        // API
        object altText
        {
            get
            {
                return Self.altText;
            }
            set
            {
                Self.altText = value;
            }
        }

        object contentSize
        {
            get
            {
                return Self.contentSize;
            }
            set
            {
                Self.contentSize = value;
            }
        }

        object fileExtension
        {
            get
            {
                return Self.fileExtension;
            }
            set
            {
                Self.fileExtension = value;
            }
        }

        object thumbnails
        {
            get
            {
                return Self.thumbnails;
            }
            set
            {
                Self.thumbnails = value;
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

        public InlineImageSegment()
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
