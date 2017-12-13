using Apex.System;

namespace Apex.Database
{
    public class Batchable
    {
        public void execute(Database.BatchableContext param1, List<object> param2)
        {
            throw new global::System.NotImplementedException("Batchable.Execute");
        }

        public void finish(Database.BatchableContext param1)
        {
            throw new global::System.NotImplementedException("Batchable.Finish");
        }

        public System.Iterable start(Database.BatchableContext param1)
        {
            throw new global::System.NotImplementedException("Batchable.Start");
        }
    }
}