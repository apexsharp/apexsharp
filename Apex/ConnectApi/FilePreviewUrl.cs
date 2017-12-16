namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FilePreviewUrl
    {
        // infrastructure
        public FilePreviewUrl(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FilePreviewUrl));
            }
        }

        // API
        object pageNumber
        {
            get
            {
                return Self.pageNumber;
            }
            set
            {
                Self.pageNumber = value;
            }
        }

        object previewUrl
        {
            get
            {
                return Self.previewUrl;
            }
            set
            {
                Self.previewUrl = value;
            }
        }

        public FilePreviewUrl()
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
