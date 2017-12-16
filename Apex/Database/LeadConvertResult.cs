namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_database_leadconvertresult.htm#apex_class_database_leadconvertresult
    /// </summary>
    public class LeadConvertResult
    {
        // infrastructure
        public LeadConvertResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LeadConvertResult));
            }
        }

        // API
        public ID getAccountId()
        {
            return Self.getAccountId();
        }

        public ID getContactId()
        {
            return Self.getContactId();
        }

        public Error[] getErrors()
        {
            return Self.getErrors();
        }

        public ID getLeadId()
        {
            return Self.getLeadId();
        }

        public ID getOpportunityId()
        {
            return Self.getOpportunityId();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
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

        List<Error> errors
        {
            get
            {
                return Self.errors;
            }
            set
            {
                Self.errors = value;
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

        bool success
        {
            get
            {
                return Self.success;
            }
            set
            {
                Self.success = value;
            }
        }
    }
}
