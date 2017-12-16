namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FilePreviewCollection
    {
        // infrastructure
        public FilePreviewCollection(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FilePreviewCollection));
            }
        }

        // API
        object fileId
        {
            get
            {
                return Self.fileId;
            }
            set
            {
                Self.fileId = value;
            }
        }

        object previews
        {
            get
            {
                return Self.previews;
            }
            set
            {
                Self.previews = value;
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

        object versionNumber
        {
            get
            {
                return Self.versionNumber;
            }
            set
            {
                Self.versionNumber = value;
            }
        }

        public FilePreviewCollection()
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
