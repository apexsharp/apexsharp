namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_DeployResult.htm#apex_class_Metadata_DeployResult
    /// </summary>
    public class DeployResult
    {
        // infrastructure
        public DeployResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DeployResult));
            }
        }

        // API
        string canceledBy
        {
            get
            {
                return Self.canceledBy;
            }
            set
            {
                Self.canceledBy = value;
            }
        }

        string canceledByName
        {
            get
            {
                return Self.canceledByName;
            }
            set
            {
                Self.canceledByName = value;
            }
        }

        bool checkOnly
        {
            get
            {
                return Self.checkOnly;
            }
            set
            {
                Self.checkOnly = value;
            }
        }

        Datetime completedDate
        {
            get
            {
                return Self.completedDate;
            }
            set
            {
                Self.completedDate = value;
            }
        }

        string createdBy
        {
            get
            {
                return Self.createdBy;
            }
            set
            {
                Self.createdBy = value;
            }
        }

        string createdByName
        {
            get
            {
                return Self.createdByName;
            }
            set
            {
                Self.createdByName = value;
            }
        }

        Datetime createdDate
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

        DeployDetails details
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

        bool done
        {
            get
            {
                return Self.done;
            }
            set
            {
                Self.done = value;
            }
        }

        string errorMessage
        {
            get
            {
                return Self.errorMessage;
            }
            set
            {
                Self.errorMessage = value;
            }
        }

        string errorStatusCode
        {
            get
            {
                return Self.errorStatusCode;
            }
            set
            {
                Self.errorStatusCode = value;
            }
        }

        ID id
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

        bool ignoreWarnings
        {
            get
            {
                return Self.ignoreWarnings;
            }
            set
            {
                Self.ignoreWarnings = value;
            }
        }

        Datetime lastModifiedDate
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

        List<DeployMessage> messages
        {
            get
            {
                return Self.messages;
            }
            set
            {
                Self.messages = value;
            }
        }

        int numberComponentErrors
        {
            get
            {
                return Self.numberComponentErrors;
            }
            set
            {
                Self.numberComponentErrors = value;
            }
        }

        int numberComponentsDeployed
        {
            get
            {
                return Self.numberComponentsDeployed;
            }
            set
            {
                Self.numberComponentsDeployed = value;
            }
        }

        int numberComponentsTotal
        {
            get
            {
                return Self.numberComponentsTotal;
            }
            set
            {
                Self.numberComponentsTotal = value;
            }
        }

        bool rollbackOnError
        {
            get
            {
                return Self.rollbackOnError;
            }
            set
            {
                Self.rollbackOnError = value;
            }
        }

        Datetime startDate
        {
            get
            {
                return Self.startDate;
            }
            set
            {
                Self.startDate = value;
            }
        }

        string stateDetail
        {
            get
            {
                return Self.stateDetail;
            }
            set
            {
                Self.stateDetail = value;
            }
        }

        DeployStatus status
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

        public object clone()
        {
            return Self.clone();
        }

        public DeployResult()
        {
            Self = Implementation.Constructor();
        }
    }
}
