namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class WorkspacePermission
    {
        // infrastructure
        public WorkspacePermission(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(WorkspacePermission));
            }
        }

        // API
        object canAddFileComments
        {
            get
            {
                return Self.canAddFileComments;
            }
            set
            {
                Self.canAddFileComments = value;
            }
        }

        object canAddFiles
        {
            get
            {
                return Self.canAddFiles;
            }
            set
            {
                Self.canAddFiles = value;
            }
        }

        object canAddFilesOnBehalfOfOthers
        {
            get
            {
                return Self.canAddFilesOnBehalfOfOthers;
            }
            set
            {
                Self.canAddFilesOnBehalfOfOthers = value;
            }
        }

        object canArchiveFiles
        {
            get
            {
                return Self.canArchiveFiles;
            }
            set
            {
                Self.canArchiveFiles = value;
            }
        }

        object canAttachOrShareFilesToFeed
        {
            get
            {
                return Self.canAttachOrShareFilesToFeed;
            }
            set
            {
                Self.canAttachOrShareFilesToFeed = value;
            }
        }

        object canDeleteFiles
        {
            get
            {
                return Self.canDeleteFiles;
            }
            set
            {
                Self.canDeleteFiles = value;
            }
        }

        object canDeliverContent
        {
            get
            {
                return Self.canDeliverContent;
            }
            set
            {
                Self.canDeliverContent = value;
            }
        }

        object canFeatureFiles
        {
            get
            {
                return Self.canFeatureFiles;
            }
            set
            {
                Self.canFeatureFiles = value;
            }
        }

        object canManageWorkspace
        {
            get
            {
                return Self.canManageWorkspace;
            }
            set
            {
                Self.canManageWorkspace = value;
            }
        }

        object canModifyFileComments
        {
            get
            {
                return Self.canModifyFileComments;
            }
            set
            {
                Self.canModifyFileComments = value;
            }
        }

        object canOrganizeFilesAndFolders
        {
            get
            {
                return Self.canOrganizeFilesAndFolders;
            }
            set
            {
                Self.canOrganizeFilesAndFolders = value;
            }
        }

        object canTagFiles
        {
            get
            {
                return Self.canTagFiles;
            }
            set
            {
                Self.canTagFiles = value;
            }
        }

        object canViewFileComments
        {
            get
            {
                return Self.canViewFileComments;
            }
            set
            {
                Self.canViewFileComments = value;
            }
        }

        public WorkspacePermission()
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
