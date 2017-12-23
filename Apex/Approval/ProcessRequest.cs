namespace Apex.Approval
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ProcessRequest.htm#apex_ProcessRequest
    /// </summary>
    public class ProcessRequest
    {
        // infrastructure
        public ProcessRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ProcessRequest));
            }
        }

        // API
        public string getComments()
        {
            return Self.getComments();
        }

        public ID[] getNextApproverIds()
        {
            return Self.getNextApproverIds();
        }

        public void setComments(string comments)
        {
            Self.setComments(comments);
        }

        public void setNextApproverIds(ID[] nextApproverIds)
        {
            Self.setNextApproverIds(nextApproverIds);
        }

        string comments
        {
            get
            {
                return Self.comments;
            }
            set
            {
                Self.comments = value;
            }
        }

        List<ID> nextApproverIds
        {
            get
            {
                return Self.nextApproverIds;
            }
            set
            {
                Self.nextApproverIds = value;
            }
        }

        public void setNextApproverIds(List<ID> param1)
        {
            Self.setNextApproverIds(param1);
        }
    }
}
