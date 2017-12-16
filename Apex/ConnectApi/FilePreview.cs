namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FilePreview
    {
        // infrastructure
        public FilePreview(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FilePreview));
            }
        }

        // API
        object format
        {
            get
            {
                return Self.format;
            }
            set
            {
                Self.format = value;
            }
        }

        object previewUrlCount
        {
            get
            {
                return Self.previewUrlCount;
            }
            set
            {
                Self.previewUrlCount = value;
            }
        }

        object previewUrls
        {
            get
            {
                return Self.previewUrls;
            }
            set
            {
                Self.previewUrls = value;
            }
        }

        object status
        {
            get
            {
                return Self.status;
            }
            set
            {
                Self.status = value;
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

        public FilePreview()
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
