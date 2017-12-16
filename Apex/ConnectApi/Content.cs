namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Content
    {
        // infrastructure
        public Content(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Content));
            }
        }

        // API
        object checksum
        {
            get
            {
                return Self.checksum;
            }
            set
            {
                Self.checksum = value;
            }
        }

        object contentUrl
        {
            get
            {
                return Self.contentUrl;
            }
            set
            {
                Self.contentUrl = value;
            }
        }

        object description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
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

        object fileSize
        {
            get
            {
                return Self.fileSize;
            }
            set
            {
                Self.fileSize = value;
            }
        }

        object fileType
        {
            get
            {
                return Self.fileType;
            }
            set
            {
                Self.fileType = value;
            }
        }

        object fileTypeEnumName
        {
            get
            {
                return Self.fileTypeEnumName;
            }
            set
            {
                Self.fileTypeEnumName = value;
            }
        }

        object hasFlashPreview
        {
            get
            {
                return Self.hasFlashPreview;
            }
            set
            {
                Self.hasFlashPreview = value;
            }
        }

        object hasPdfPreview
        {
            get
            {
                return Self.hasPdfPreview;
            }
            set
            {
                Self.hasPdfPreview = value;
            }
        }

        object hasTinyThumbnailPreview
        {
            get
            {
                return Self.hasTinyThumbnailPreview;
            }
            set
            {
                Self.hasTinyThumbnailPreview = value;
            }
        }

        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

        object isContextUserSubscribedToDocument
        {
            get
            {
                return Self.isContextUserSubscribedToDocument;
            }
            set
            {
                Self.isContextUserSubscribedToDocument = value;
            }
        }

        object isInMyFileSync
        {
            get
            {
                return Self.isInMyFileSync;
            }
            set
            {
                Self.isInMyFileSync = value;
            }
        }

        object isRenditionProcessing
        {
            get
            {
                return Self.isRenditionProcessing;
            }
            set
            {
                Self.isRenditionProcessing = value;
            }
        }

        object isSyncAvailable
        {
            get
            {
                return Self.isSyncAvailable;
            }
            set
            {
                Self.isSyncAvailable = value;
            }
        }

        object lastModifiedDate
        {
            get
            {
                return Self.lastModifiedDate;
            }
            set
            {
                Self.lastModifiedDate = value;
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

        object renditionUrl
        {
            get
            {
                return Self.renditionUrl;
            }
            set
            {
                Self.renditionUrl = value;
            }
        }

        object renditionUrl240By180
        {
            get
            {
                return Self.renditionUrl240By180;
            }
            set
            {
                Self.renditionUrl240By180 = value;
            }
        }

        object renditionUrl720By480
        {
            get
            {
                return Self.renditionUrl720By480;
            }
            set
            {
                Self.renditionUrl720By480 = value;
            }
        }

        object sharingOption
        {
            get
            {
                return Self.sharingOption;
            }
            set
            {
                Self.sharingOption = value;
            }
        }

        object textPreview
        {
            get
            {
                return Self.textPreview;
            }
            set
            {
                Self.textPreview = value;
            }
        }

        object thumb120By90RenditionStatus
        {
            get
            {
                return Self.thumb120By90RenditionStatus;
            }
            set
            {
                Self.thumb120By90RenditionStatus = value;
            }
        }

        object thumb240By180RenditionStatus
        {
            get
            {
                return Self.thumb240By180RenditionStatus;
            }
            set
            {
                Self.thumb240By180RenditionStatus = value;
            }
        }

        object thumb720By480RenditionStatus
        {
            get
            {
                return Self.thumb720By480RenditionStatus;
            }
            set
            {
                Self.thumb720By480RenditionStatus = value;
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

        public Content()
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
