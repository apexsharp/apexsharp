using Apex.System;

using SObject = Apex.System.SObject;

namespace Apex.UserProvisioning
{
    public class CommittingBatchable
    {
        public CommittingBatchable(string uprId)
        {
            throw new global::System.NotImplementedException("CommittingBatchable");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("CommittingBatchable.Clone");
        }

        public void execute(Database.BatchableContext BC, List<SObject> scope)
        {
            throw new global::System.NotImplementedException("CommittingBatchable.Execute");
        }

        public void finish(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("CommittingBatchable.Finish");
        }

        public Database.QueryLocator start(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("CommittingBatchable.Start");
        }
    }
}