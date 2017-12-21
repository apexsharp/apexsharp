using Apex.System;

using SObject = Apex.System.SObject;

namespace Apex.UserProvisioning
{
    public class UPASCleaningBatchable
    {
        public UPASCleaningBatchable(string uprId)
        {
            throw new global::System.NotImplementedException("UPASCleaningBatchable");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("UPASCleaningBatchable.Clone");
        }

        public void execute(Database.BatchableContext BC, List<SObject> scope)
        {
            throw new global::System.NotImplementedException("UPASCleaningBatchable.Execute");
        }

        public void finish(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("UPASCleaningBatchable.Finish");
        }

        public Database.QueryLocator start(Database.BatchableContext BC)
        {
            throw new global::System.NotImplementedException("UPASCleaningBatchable.Start");
        }
    }
}