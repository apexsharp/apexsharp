namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ProvisioningProcessHandlerInput
    {
        // infrastructure
        public ProvisioningProcessHandlerInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ProvisioningProcessHandlerInput));
            }
        }

        // API
        string namedCredDevName
        {
            get
            {
                return Self.namedCredDevName;
            }
            set
            {
                Self.namedCredDevName = value;
            }
        }

        string reconFilter
        {
            get
            {
                return Self.reconFilter;
            }
            set
            {
                Self.reconFilter = value;
            }
        }

        string reconOffset
        {
            get
            {
                return Self.reconOffset;
            }
            set
            {
                Self.reconOffset = value;
            }
        }

        string userId
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

        string userProvisioningRequestId
        {
            get
            {
                return Self.userProvisioningRequestId;
            }
            set
            {
                Self.userProvisioningRequestId = value;
            }
        }

        public ProvisioningProcessHandlerInput(string userProvisioningRequestId, string userId, string namedCredDevName, string reconFilter, string reconOffset)
        {
            Self = Implementation.Constructor(userProvisioningRequestId, userId, namedCredDevName, reconFilter, reconOffset);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getNamedCredDevName()
        {
            return Self.getNamedCredDevName();
        }

        public string getReconFilter()
        {
            return Self.getReconFilter();
        }

        public string getReconOffset()
        {
            return Self.getReconOffset();
        }

        public string getUserId()
        {
            return Self.getUserId();
        }

        public string getUserProvisioningRequestId()
        {
            return Self.getUserProvisioningRequestId();
        }

        public void setNamedCredDevName(string namedCredDevName)
        {
            Self.setNamedCredDevName(namedCredDevName);
        }

        public void setReconFilter(string reconFilter)
        {
            Self.setReconFilter(reconFilter);
        }

        public void setReconOffset(string reconOffset)
        {
            Self.setReconOffset(reconOffset);
        }

        public void setUserId(string userId)
        {
            Self.setUserId(userId);
        }

        public void setUserProvisioningRequestId(string userProvisioningRequestId)
        {
            Self.setUserProvisioningRequestId(userProvisioningRequestId);
        }
    }
}
