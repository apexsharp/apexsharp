namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_dml_convertLead.htm#apex_dml_convertLead
    /// </summary>
    public class LeadConvert
    {
        // infrastructure
        public LeadConvert(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LeadConvert));
            }
        }

        // API
        public LeadConvert()
        {
            Implementation.Constructor();
        }

        public ID getAccountId()
        {
            return Self.getAccountId();
        }

        public ID getContactId()
        {
            return Self.getContactId();
        }

        public string getConvertedStatus()
        {
            return Self.getConvertedStatus();
        }

        public ID getLeadID()
        {
            return Self.getLeadID();
        }

        public string getOpportunityName()
        {
            return Self.getOpportunityName();
        }

        public ID getOwnerID()
        {
            return Self.getOwnerID();
        }

        public bool isDoNotCreateOpportunity()
        {
            return Self.isDoNotCreateOpportunity();
        }

        public bool isOverWriteLeadSource()
        {
            return Self.isOverWriteLeadSource();
        }

        public bool isSendNotificationEmail()
        {
            return Self.isSendNotificationEmail();
        }

        public void setAccountId(ID accountId)
        {
            Self.setAccountId(accountId);
        }

        public void setContactId(ID contactId)
        {
            Self.setContactId(contactId);
        }

        public void setConvertedStatus(string status)
        {
            Self.setConvertedStatus(status);
        }

        public void setDoNotCreateOpportunity(bool createOpportunity)
        {
            Self.setDoNotCreateOpportunity(createOpportunity);
        }

        public void setLeadId(ID leadId)
        {
            Self.setLeadId(leadId);
        }

        public void setOpportunityName(string opportunityName)
        {
            Self.setOpportunityName(opportunityName);
        }

        public void setOverwriteLeadSource(bool overwriteLeadSource)
        {
            Self.setOverwriteLeadSource(overwriteLeadSource);
        }

        public void setOwnerId(ID ownerId)
        {
            Self.setOwnerId(ownerId);
        }

        public void setSendNotificationEmail(bool sendEmail)
        {
            Self.setSendNotificationEmail(sendEmail);
        }

        ID accountId
        {
            get
            {
                return Self.accountId;
            }
            set
            {
                Self.accountId = value;
            }
        }

        SObject accountRecord
        {
            get
            {
                return Self.accountRecord;
            }
            set
            {
                Self.accountRecord = value;
            }
        }

        bool bypassAccountDedupeCheck
        {
            get
            {
                return Self.bypassAccountDedupeCheck;
            }
            set
            {
                Self.bypassAccountDedupeCheck = value;
            }
        }

        bool bypassContactDedupeCheck
        {
            get
            {
                return Self.bypassContactDedupeCheck;
            }
            set
            {
                Self.bypassContactDedupeCheck = value;
            }
        }

        ID contactId
        {
            get
            {
                return Self.contactId;
            }
            set
            {
                Self.contactId = value;
            }
        }

        SObject contactRecord
        {
            get
            {
                return Self.contactRecord;
            }
            set
            {
                Self.contactRecord = value;
            }
        }

        string convertedStatus
        {
            get
            {
                return Self.convertedStatus;
            }
            set
            {
                Self.convertedStatus = value;
            }
        }

        bool doNotCreateOpportunity
        {
            get
            {
                return Self.doNotCreateOpportunity;
            }
            set
            {
                Self.doNotCreateOpportunity = value;
            }
        }

        ID leadId
        {
            get
            {
                return Self.leadId;
            }
            set
            {
                Self.leadId = value;
            }
        }

        ID opportunityId
        {
            get
            {
                return Self.opportunityId;
            }
            set
            {
                Self.opportunityId = value;
            }
        }

        string opportunityName
        {
            get
            {
                return Self.opportunityName;
            }
            set
            {
                Self.opportunityName = value;
            }
        }

        SObject opportunityRecord
        {
            get
            {
                return Self.opportunityRecord;
            }
            set
            {
                Self.opportunityRecord = value;
            }
        }

        bool overwriteLeadSource
        {
            get
            {
                return Self.overwriteLeadSource;
            }
            set
            {
                Self.overwriteLeadSource = value;
            }
        }

        ID ownerId
        {
            get
            {
                return Self.ownerId;
            }
            set
            {
                Self.ownerId = value;
            }
        }

        bool sendNotificationEmail
        {
            get
            {
                return Self.sendNotificationEmail;
            }
            set
            {
                Self.sendNotificationEmail = value;
            }
        }

        public SObject getAccountRecord()
        {
            return Self.getAccountRecord();
        }

        public bool getBypassAccountDedupeCheck()
        {
            return Self.getBypassAccountDedupeCheck();
        }

        public bool getBypassContactDedupeCheck()
        {
            return Self.getBypassContactDedupeCheck();
        }

        public SObject getContactRecord()
        {
            return Self.getContactRecord();
        }

        public ID getLeadId()
        {
            return Self.getLeadId();
        }

        public ID getOpportunityId()
        {
            return Self.getOpportunityId();
        }

        public SObject getOpportunityRecord()
        {
            return Self.getOpportunityRecord();
        }

        public ID getOwnerId()
        {
            return Self.getOwnerId();
        }

        public bool isOverwriteLeadSource()
        {
            return Self.isOverwriteLeadSource();
        }

        public void setAccountRecord(SObject param1)
        {
            Self.setAccountRecord(param1);
        }

        public void setBypassAccountDedupeCheck(bool param1)
        {
            Self.setBypassAccountDedupeCheck(param1);
        }

        public void setBypassContactDedupeCheck(bool param1)
        {
            Self.setBypassContactDedupeCheck(param1);
        }

        public void setContactRecord(SObject param1)
        {
            Self.setContactRecord(param1);
        }

        public void setOpportunityId(ID param1)
        {
            Self.setOpportunityId(param1);
        }

        public void setOpportunityRecord(SObject param1)
        {
            Self.setOpportunityRecord(param1);
        }
    }
}
