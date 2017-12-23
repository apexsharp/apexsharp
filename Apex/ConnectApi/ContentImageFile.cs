namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentImageFile
    {
        // infrastructure
        public ContentImageFile(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentImageFile));
            }
        }

        // API
        object masterDetail
        {
            get
            {
                return Self.masterDetail;
            }
            set
            {
                Self.masterDetail = value;
            }
        }

        object renditionDimensions
        {
            get
            {
                return Self.renditionDimensions;
            }
            set
            {
                Self.renditionDimensions = value;
            }
        }

        public ContentImageFile()
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
