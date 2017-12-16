namespace Apex.Approval
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ProcessWorkitemRequest.htm#apex_ProcessWorkitemRequest
    /// </summary>
    public class ProcessWorkitemRequest
    {
        // infrastructure
        public ProcessWorkitemRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ProcessWorkitemRequest));
            }
        }

        // API
        public string getAction()
        {
            return Self.getAction();
        }

        public string getWorkitemId()
        {
            return Self.getWorkitemId();
        }

        public void setAction(string actionType)
        {
            Self.setAction(actionType);
        }

        public void setWorkitemId(string id)
        {
            Self.setWorkitemId(id);
        }

        string action
        {
            get
            {
                return Self.action;
            }
            set
            {
                Self.action = value;
            }
        }

        string workitemId
        {
            get
            {
                return Self.workitemId;
            }
            set
            {
                Self.workitemId = value;
            }
        }

        public ProcessWorkitemRequest()
        {
            Implementation.Constructor();
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
