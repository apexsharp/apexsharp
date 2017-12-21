using Apex.System;

using SObject = Apex.System.SObject;

namespace Apex.UserProvisioning
{
    public class PluginBatchable
    {
        public PluginBatchable(List<SObject> newRows)
        {
            throw new global::System.NotImplementedException("PluginBatchable");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("PluginBatchable.Clone");
        }

        //public void Execute(Database.BatchableContext BC,List<UserProvisioningRequest> scope){throw new global::System.NotImplementedException("PluginBatchable.Execute");}
        public Map<String, object> flowInputPreprocessing(Map<String, object> param1)
        {
            throw new global::System.NotImplementedException("PluginBatchable.FlowInputPreprocessing");
        }

        public void flowPostProcessing(UserProvisioning.ProvisioningProcessHandlerOutput param1, SObject param2)
        {
            throw new global::System.NotImplementedException("PluginBatchable.FlowPostProcessing");
        }

        public string getEventPrefix()
        {
            throw new global::System.NotImplementedException("PluginBatchable.GetEventPrefix");
        }

        public string getFlowName()
        {
            throw new global::System.NotImplementedException("PluginBatchable.GetFlowName");
        }

        public string getFlowNamespace()
        {
            throw new global::System.NotImplementedException("PluginBatchable.GetFlowNamespace");
        }

        public List<SObject> getPerBatchUPL()
        {
            throw new global::System.NotImplementedException("PluginBatchable.GetPerBatchUPL");
        }

        //public List<UserProvisioningRequest> GetPerBatchUPR(){throw new global::System.NotImplementedException("PluginBatchable.GetPerBatchUPR");}
        public Map<ID, SObject> getUprToNewUplMap()
        {
            throw new global::System.NotImplementedException("PluginBatchable.GetUprToNewUplMap");
        }

        public bool hasFlow()
        {
            throw new global::System.NotImplementedException("PluginBatchable.HasFlow");
        }

        public bool hasFlowOrApex()
        {
            throw new global::System.NotImplementedException("PluginBatchable.HasFlowOrApex");
        }

        public void postBatchProcessing()
        {
            throw new global::System.NotImplementedException("PluginBatchable.PostBatchProcessing");
        }

        public Database.QueryLocator start(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("PluginBatchable.Start");
        }
    }
}