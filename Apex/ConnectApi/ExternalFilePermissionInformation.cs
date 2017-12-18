namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ExternalFilePermissionInformation
    {
        // infrastructure
        public ExternalFilePermissionInformation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ExternalFilePermissionInformation));
            }
        }

        // API
        object externalFilePermissionsFailure
        {
            get
            {
                return Self.externalFilePermissionsFailure;
            }
            set
            {
                Self.externalFilePermissionsFailure = value;
            }
        }

        object externalFilePermissionsInfoFailureReason
        {
            get
            {
                return Self.externalFilePermissionsInfoFailureReason;
            }
            set
            {
                Self.externalFilePermissionsInfoFailureReason = value;
            }
        }

        object externalFilePermissionTypes
        {
            get
            {
                return Self.externalFilePermissionTypes;
            }
            set
            {
                Self.externalFilePermissionTypes = value;
            }
        }

        object externalFileSharingStatus
        {
            get
            {
                return Self.externalFileSharingStatus;
            }
            set
            {
                Self.externalFileSharingStatus = value;
            }
        }

        object repositoryPublicGroups
        {
            get
            {
                return Self.repositoryPublicGroups;
            }
            set
            {
                Self.repositoryPublicGroups = value;
            }
        }

        public ExternalFilePermissionInformation()
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
