namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ProvisioningProcessHandlerOutput
    {
        // infrastructure
        public ProvisioningProcessHandlerOutput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ProvisioningProcessHandlerOutput));
            }
        }

        // API
        string details
        {
            get
            {
                return Self.details;
            }
            set
            {
                Self.details = value;
            }
        }

        string externalEmail
        {
            get
            {
                return Self.externalEmail;
            }
            set
            {
                Self.externalEmail = value;
            }
        }

        string externalFirstName
        {
            get
            {
                return Self.externalFirstName;
            }
            set
            {
                Self.externalFirstName = value;
            }
        }

        string externalLastName
        {
            get
            {
                return Self.externalLastName;
            }
            set
            {
                Self.externalLastName = value;
            }
        }

        string externalUserId
        {
            get
            {
                return Self.externalUserId;
            }
            set
            {
                Self.externalUserId = value;
            }
        }

        string externalUsername
        {
            get
            {
                return Self.externalUsername;
            }
            set
            {
                Self.externalUsername = value;
            }
        }

        string nextReconOffset
        {
            get
            {
                return Self.nextReconOffset;
            }
            set
            {
                Self.nextReconOffset = value;
            }
        }

        string reconState
        {
            get
            {
                return Self.reconState;
            }
            set
            {
                Self.reconState = value;
            }
        }

        string status
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

        string UPAStatus
        {
            get
            {
                return Self.UPAStatus;
            }
            set
            {
                Self.UPAStatus = value;
            }
        }

        public ProvisioningProcessHandlerOutput()
        {
            Implementation.Constructor();
        }

        public ProvisioningProcessHandlerOutput(string status, string details, string externalUserId, string externalUsername, string externalEmail, string externalFirstName, string externalLastName, string UPAStatus, string nextReconOffset)
        {
            Implementation.Constructor(status, details, externalUserId, externalUsername, externalEmail, externalFirstName, externalLastName, UPAStatus, nextReconOffset);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getDetails()
        {
            return Self.getDetails();
        }

        public string getExternalEmail()
        {
            return Self.getExternalEmail();
        }

        public string getExternalFirstName()
        {
            return Self.getExternalFirstName();
        }

        public string getExternalLastName()
        {
            return Self.getExternalLastName();
        }

        public string getExternalUserId()
        {
            return Self.getExternalUserId();
        }

        public string getExternalUsername()
        {
            return Self.getExternalUsername();
        }

        public string getNextReconOffset()
        {
            return Self.getNextReconOffset();
        }

        public string getReconState()
        {
            return Self.getReconState();
        }

        public string getStatus()
        {
            return Self.getStatus();
        }

        public string getUPAStatus()
        {
            return Self.getUPAStatus();
        }

        public void setDetails(string details)
        {
            Self.setDetails(details);
        }

        public void setExternalEmail(string externalEmail)
        {
            Self.setExternalEmail(externalEmail);
        }

        public void setExternalFirstName(string externalFirstName)
        {
            Self.setExternalFirstName(externalFirstName);
        }

        public void setExternalLastName(string externalLastName)
        {
            Self.setExternalLastName(externalLastName);
        }

        public void setExternalUserId(string externalUserId)
        {
            Self.setExternalUserId(externalUserId);
        }

        public void setExternalUsername(string externalUsername)
        {
            Self.setExternalUsername(externalUsername);
        }

        public void setNextReconOffset(string nextReconOffset)
        {
            Self.setNextReconOffset(nextReconOffset);
        }

        public void setReconState(string reconState)
        {
            Self.setReconState(reconState);
        }

        public void setStatus(string status)
        {
            Self.setStatus(status);
        }

        public void setUPAStatus(string UPAStatus)
        {
            Self.setUPAStatus(UPAStatus);
        }
    }
}
