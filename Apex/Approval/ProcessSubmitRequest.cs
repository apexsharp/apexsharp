namespace Apex.Approval
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ProcessSubmitRequest.htm#apex_ProcessSubmitRequest
    /// </summary>
    public class ProcessSubmitRequest
    {
        // infrastructure
        public ProcessSubmitRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ProcessSubmitRequest));
            }
        }

        // API
        public string getObjectId()
        {
            return Self.getObjectId();
        }

        public string getProcessDefinitionNameOrId()
        {
            return Self.getProcessDefinitionNameOrId();
        }

        public bool getSkipEntryCriteria()
        {
            return Self.getSkipEntryCriteria();
        }

        public string getSubmitterId()
        {
            return Self.getSubmitterId();
        }

        public void setObjectId(string recordId)
        {
            Self.setObjectId(recordId);
        }

        public void setProcessDefinitionNameOrId(string nameOrId)
        {
            Self.setProcessDefinitionNameOrId(nameOrId);
        }

        public void setSkipEntryCriteria(bool skipEntryCriteria)
        {
            Self.setSkipEntryCriteria(skipEntryCriteria);
        }

        public void setSubmitterId(string userID)
        {
            Self.setSubmitterId(userID);
        }

        string objectId
        {
            get
            {
                return Self.objectId;
            }
            set
            {
                Self.objectId = value;
            }
        }

        string processDefinitionNameOrId
        {
            get
            {
                return Self.processDefinitionNameOrId;
            }
            set
            {
                Self.processDefinitionNameOrId = value;
            }
        }

        bool skipEntryCriteria
        {
            get
            {
                return Self.skipEntryCriteria;
            }
            set
            {
                Self.skipEntryCriteria = value;
            }
        }

        string submitterId
        {
            get
            {
                return Self.submitterId;
            }
            set
            {
                Self.submitterId = value;
            }
        }

        public ProcessSubmitRequest()
        {
            Self = Implementation.Constructor();
        }

        public string getComments()
        {
            return Self.getComments();
        }

        public List<ID> getNextApproverIds()
        {
            return Self.getNextApproverIds();
        }

        public void setComments(string param1)
        {
            Self.setComments(param1);
        }

        public void setNextApproverIds(List<ID> param1)
        {
            Self.setNextApproverIds(param1);
        }
    }
}
