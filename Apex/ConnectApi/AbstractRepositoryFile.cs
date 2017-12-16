namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AbstractRepositoryFile
    {
        // infrastructure
        public AbstractRepositoryFile(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AbstractRepositoryFile));
            }
        }

        // API
        object checkinComment
        {
            get
            {
                return Self.checkinComment;
            }
            set
            {
                Self.checkinComment = value;
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

        object downloadUrl
        {
            get
            {
                return Self.downloadUrl;
            }
            set
            {
                Self.downloadUrl = value;
            }
        }

        object externalContentUrl
        {
            get
            {
                return Self.externalContentUrl;
            }
            set
            {
                Self.externalContentUrl = value;
            }
        }

        object externalDocumentUrl
        {
            get
            {
                return Self.externalDocumentUrl;
            }
            set
            {
                Self.externalDocumentUrl = value;
            }
        }

        object externalFilePermissionInformation
        {
            get
            {
                return Self.externalFilePermissionInformation;
            }
            set
            {
                Self.externalFilePermissionInformation = value;
            }
        }

        object mimeType
        {
            get
            {
                return Self.mimeType;
            }
            set
            {
                Self.mimeType = value;
            }
        }

        object previewsUrl
        {
            get
            {
                return Self.previewsUrl;
            }
            set
            {
                Self.previewsUrl = value;
            }
        }

        object previewUrlThumbnail
        {
            get
            {
                return Self.previewUrlThumbnail;
            }
            set
            {
                Self.previewUrlThumbnail = value;
            }
        }

        object previewUrlThumbnailBig
        {
            get
            {
                return Self.previewUrlThumbnailBig;
            }
            set
            {
                Self.previewUrlThumbnailBig = value;
            }
        }

        object previewUrlThumbnailTiny
        {
            get
            {
                return Self.previewUrlThumbnailTiny;
            }
            set
            {
                Self.previewUrlThumbnailTiny = value;
            }
        }

        object title
        {
            get
            {
                return Self.title;
            }
            set
            {
                Self.title = value;
            }
        }

        object versionId
        {
            get
            {
                return Self.versionId;
            }
            set
            {
                Self.versionId = value;
            }
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
