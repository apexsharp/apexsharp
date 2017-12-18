namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SocialCustomerServiceConfig
    {
        // infrastructure
        public SocialCustomerServiceConfig(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialCustomerServiceConfig));
            }
        }

        // API
        object inboundApexHandlerId
        {
            get
            {
                return Self.inboundApexHandlerId;
            }
            set
            {
                Self.inboundApexHandlerId = value;
            }
        }

        object isInboundParentPostEnabled
        {
            get
            {
                return Self.isInboundParentPostEnabled;
            }
            set
            {
                Self.isInboundParentPostEnabled = value;
            }
        }

        object isPackageInstalled
        {
            get
            {
                return Self.isPackageInstalled;
            }
            set
            {
                Self.isPackageInstalled = value;
            }
        }

        object isSocialPublishingApprovalEnabled
        {
            get
            {
                return Self.isSocialPublishingApprovalEnabled;
            }
            set
            {
                Self.isSocialPublishingApprovalEnabled = value;
            }
        }

        object isTenantConnectionValid
        {
            get
            {
                return Self.isTenantConnectionValid;
            }
            set
            {
                Self.isTenantConnectionValid = value;
            }
        }

        object managedSocialAccountCount
        {
            get
            {
                return Self.managedSocialAccountCount;
            }
            set
            {
                Self.managedSocialAccountCount = value;
            }
        }

        object managedSocialAccountLimit
        {
            get
            {
                return Self.managedSocialAccountLimit;
            }
            set
            {
                Self.managedSocialAccountLimit = value;
            }
        }

        object runAsUserId
        {
            get
            {
                return Self.runAsUserId;
            }
            set
            {
                Self.runAsUserId = value;
            }
        }

        object setupTenantUrl
        {
            get
            {
                return Self.setupTenantUrl;
            }
            set
            {
                Self.setupTenantUrl = value;
            }
        }

        object tenantType
        {
            get
            {
                return Self.tenantType;
            }
            set
            {
                Self.tenantType = value;
            }
        }

        public SocialCustomerServiceConfig()
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
