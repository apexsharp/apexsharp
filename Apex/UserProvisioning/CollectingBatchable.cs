using Apex.System;
using ApexSharpApi.ApexApi;

namespace Apex.UserProvisioning
{
    public class CollectingBatchable
    {
        public CollectingBatchable(string reconOffset, string uprId, string connectedAppId)
        {
            throw new global::System.NotImplementedException("CollectingBatchable");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("CollectingBatchable.Clone");
        }

        //public void Execute(Database.BatchableContext BC,List<UserProvisioningRequest> scope){throw new global::System.NotImplementedException("CollectingBatchable.Execute");}
        public void finish(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("CollectingBatchable.Finish");
        }

        public Map<String, object> flowInputPreprocessing(Map<String, object> myMap)
        {
            throw new global::System.NotImplementedException("CollectingBatchable.FlowInputPreprocessing");
        }

        public void flowPostProcessing(UserProvisioning.ProvisioningProcessHandlerOutput provOutput, SObject thisUPR)
        {
            throw new global::System.NotImplementedException("CollectingBatchable.FlowPostProcessing");
        }

        public string getEventPrefix()
        {
            throw new global::System.NotImplementedException("CollectingBatchable.GetEventPrefix");
        }

        public string getFlowName()
        {
            throw new global::System.NotImplementedException("CollectingBatchable.GetFlowName");
        }

        public string getFlowNamespace()
        {
            throw new global::System.NotImplementedException("CollectingBatchable.GetFlowNamespace");
        }

        public List<SObject> getPerBatchUPL()
        {
            throw new global::System.NotImplementedException("CollectingBatchable.GetPerBatchUPL");
        }

        //public List<UserProvisioningRequest> GetPerBatchUPR(){throw new global::System.NotImplementedException("CollectingBatchable.GetPerBatchUPR");}
        public Map<ID, SObject> getUprToNewUplMap()
        {
            throw new global::System.NotImplementedException("CollectingBatchable.GetUprToNewUplMap");
        }

        public bool hasFlow()
        {
            throw new global::System.NotImplementedException("CollectingBatchable.HasFlow");
        }

        public bool hasFlowOrApex()
        {
            throw new global::System.NotImplementedException("CollectingBatchable.HasFlowOrApex");
        }

        public void postBatchProcessing()
        {
            throw new global::System.NotImplementedException("CollectingBatchable.PostBatchProcessing");
        }

        public Database.QueryLocator start(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("CollectingBatchable.Start");
        }
    }
}