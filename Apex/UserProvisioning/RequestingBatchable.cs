using Apex.System;

using SObject = Apex.System.SObject;

namespace Apex.UserProvisioning
{
    public class RequestingBatchable
    {
        public RequestingBatchable(List<SObject> newRows)
        {
            throw new global::System.NotImplementedException("RequestingBatchable");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("RequestingBatchable.Clone");
        }

        //public void Execute(Database.BatchableContext BC,List<UserProvisioningRequest> scope){throw new global::System.NotImplementedException("RequestingBatchable.Execute");}
        public void finish(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("RequestingBatchable.Finish");
        }

        public Database.QueryLocator start(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("RequestingBatchable.Start");
        }
    }
}