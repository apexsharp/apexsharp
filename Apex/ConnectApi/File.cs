namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class File
    {
        // infrastructure
        public File(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(File));
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

        object contentModifiedDate
        {
            get
            {
                return Self.contentModifiedDate;
            }
            set
            {
                Self.contentModifiedDate = value;
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

        object createdDate
        {
            get
            {
                return Self.createdDate;
            }
            set
            {
                Self.createdDate = value;
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

        object flashRenditionStatus
        {
            get
            {
                return Self.flashRenditionStatus;
            }
            set
            {
                Self.flashRenditionStatus = value;
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

        object isMajorVersion
        {
            get
            {
                return Self.isMajorVersion;
            }
            set
            {
                Self.isMajorVersion = value;
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

        object moderationFlags
        {
            get
            {
                return Self.moderationFlags;
            }
            set
            {
                Self.moderationFlags = value;
            }
        }

        object modifiedDate
        {
            get
            {
                return Self.modifiedDate;
            }
            set
            {
                Self.modifiedDate = value;
            }
        }

        object origin
        {
            get
            {
                return Self.origin;
            }
            set
            {
                Self.origin = value;
            }
        }

        object owner
        {
            get
            {
                return Self.owner;
            }
            set
            {
                Self.owner = value;
            }
        }

        object pdfRenditionStatus
        {
            get
            {
                return Self.pdfRenditionStatus;
            }
            set
            {
                Self.pdfRenditionStatus = value;
            }
        }

        object publishStatus
        {
            get
            {
                return Self.publishStatus;
            }
            set
            {
                Self.publishStatus = value;
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

        object sharingPrivacy
        {
            get
            {
                return Self.sharingPrivacy;
            }
            set
            {
                Self.sharingPrivacy = value;
            }
        }

        object sharingRole
        {
            get
            {
                return Self.sharingRole;
            }
            set
            {
                Self.sharingRole = value;
            }
        }

        object systemModstamp
        {
            get
            {
                return Self.systemModstamp;
            }
            set
            {
                Self.systemModstamp = value;
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
