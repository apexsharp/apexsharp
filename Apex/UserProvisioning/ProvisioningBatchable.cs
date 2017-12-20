using Apex.System;

using SObject = Apex.System.SObject;

namespace Apex.UserProvisioning
{
    public class ProvisioningBatchable
    {
        public ProvisioningBatchable(List<SObject> newRows)
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.Clone");
        }

        //public void Execute(Database.BatchableContext BC,List<UserProvisioningRequest> scope){throw new global::System.NotImplementedException("ProvisioningBatchable.Execute");}
        public void finish(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.Finish");
        }

        public Map<String, object> flowInputPreprocessing(Map<String, object> myMap)
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.FlowInputPreprocessing");
        }

        public void flowPostProcessing(UserProvisioning.ProvisioningProcessHandlerOutput provOutput, SObject thisUPR)
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.FlowPostProcessing");
        }

        public string getEventPrefix()
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.GetEventPrefix");
        }

        public string getFlowName()
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.GetFlowName");
        }

        public string getFlowNamespace()
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.GetFlowNamespace");
        }

        public List<SObject> getPerBatchUPL()
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.GetPerBatchUPL");
        }

        //public List<UserProvisioningRequest> GetPerBatchUPR(){throw new global::System.NotImplementedException("ProvisioningBatchable.GetPerBatchUPR");}
        public Map<ID, SObject> getUprToNewUplMap()
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.GetUprToNewUplMap");
        }

        public bool hasFlow()
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.HasFlow");
        }

        public bool hasFlowOrApex()
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.HasFlowOrApex");
        }

        public void postBatchProcessing()
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.PostBatchProcessing");
        }

        public Database.QueryLocator start(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("ProvisioningBatchable.Start");
        }
    }
}