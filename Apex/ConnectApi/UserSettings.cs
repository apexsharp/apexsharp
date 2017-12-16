namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UserSettings
    {
        // infrastructure
        public UserSettings(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserSettings));
            }
        }

        // API
        object approvalPosts
        {
            get
            {
                return Self.approvalPosts;
            }
            set
            {
                Self.approvalPosts = value;
            }
        }

        object canAccessPersonalStreams
        {
            get
            {
                return Self.canAccessPersonalStreams;
            }
            set
            {
                Self.canAccessPersonalStreams = value;
            }
        }

        object canFollow
        {
            get
            {
                return Self.canFollow;
            }
            set
            {
                Self.canFollow = value;
            }
        }

        object canModifyAllData
        {
            get
            {
                return Self.canModifyAllData;
            }
            set
            {
                Self.canModifyAllData = value;
            }
        }

        object canOwnGroups
        {
            get
            {
                return Self.canOwnGroups;
            }
            set
            {
                Self.canOwnGroups = value;
            }
        }

        object canViewAllData
        {
            get
            {
                return Self.canViewAllData;
            }
            set
            {
                Self.canViewAllData = value;
            }
        }

        object canViewAllGroups
        {
            get
            {
                return Self.canViewAllGroups;
            }
            set
            {
                Self.canViewAllGroups = value;
            }
        }

        object canViewAllUsers
        {
            get
            {
                return Self.canViewAllUsers;
            }
            set
            {
                Self.canViewAllUsers = value;
            }
        }

        object canViewCommunitySwitcher
        {
            get
            {
                return Self.canViewCommunitySwitcher;
            }
            set
            {
                Self.canViewCommunitySwitcher = value;
            }
        }

        object canViewFullUserProfile
        {
            get
            {
                return Self.canViewFullUserProfile;
            }
            set
            {
                Self.canViewFullUserProfile = value;
            }
        }

        object canViewPublicFiles
        {
            get
            {
                return Self.canViewPublicFiles;
            }
            set
            {
                Self.canViewPublicFiles = value;
            }
        }

        object currencySymbol
        {
            get
            {
                return Self.currencySymbol;
            }
            set
            {
                Self.currencySymbol = value;
            }
        }

        object externalUser
        {
            get
            {
                return Self.externalUser;
            }
            set
            {
                Self.externalUser = value;
            }
        }

        object fileSyncLimit
        {
            get
            {
                return Self.fileSyncLimit;
            }
            set
            {
                Self.fileSyncLimit = value;
            }
        }

        object fileSyncStorageLimit
        {
            get
            {
                return Self.fileSyncStorageLimit;
            }
            set
            {
                Self.fileSyncStorageLimit = value;
            }
        }

        object folderSyncLimit
        {
            get
            {
                return Self.folderSyncLimit;
            }
            set
            {
                Self.folderSyncLimit = value;
            }
        }

        object hasAccessToInternalOrg
        {
            get
            {
                return Self.hasAccessToInternalOrg;
            }
            set
            {
                Self.hasAccessToInternalOrg = value;
            }
        }

        object hasChatter
        {
            get
            {
                return Self.hasChatter;
            }
            set
            {
                Self.hasChatter = value;
            }
        }

        object hasFieldServiceLocationTracking
        {
            get
            {
                return Self.hasFieldServiceLocationTracking;
            }
            set
            {
                Self.hasFieldServiceLocationTracking = value;
            }
        }

        object hasFieldServiceMobileAccess
        {
            get
            {
                return Self.hasFieldServiceMobileAccess;
            }
            set
            {
                Self.hasFieldServiceMobileAccess = value;
            }
        }

        object hasFileSync
        {
            get
            {
                return Self.hasFileSync;
            }
            set
            {
                Self.hasFileSync = value;
            }
        }

        object hasFileSyncManagedClientAutoUpdate
        {
            get
            {
                return Self.hasFileSyncManagedClientAutoUpdate;
            }
            set
            {
                Self.hasFileSyncManagedClientAutoUpdate = value;
            }
        }

        object hasRestDataApiAccess
        {
            get
            {
                return Self.hasRestDataApiAccess;
            }
            set
            {
                Self.hasRestDataApiAccess = value;
            }
        }

        object timeZone
        {
            get
            {
                return Self.timeZone;
            }
            set
            {
                Self.timeZone = value;
            }
        }

        object userDefaultCurrencyIsoCode
        {
            get
            {
                return Self.userDefaultCurrencyIsoCode;
            }
            set
            {
                Self.userDefaultCurrencyIsoCode = value;
            }
        }

        object userId
        {
            get
            {
                return Self.userId;
            }
            set
            {
                Self.userId = value;
            }
        }

        object userLocale
        {
            get
            {
                return Self.userLocale;
            }
            set
            {
                Self.userLocale = value;
            }
        }

        public UserSettings()
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
