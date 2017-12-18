namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UPASCleaningBatchable
    {
        // infrastructure
        public UPASCleaningBatchable(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UPASCleaningBatchable));
            }
        }

        // API
        public UPASCleaningBatchable(string uprId)
        {
            Self = Implementation.Constructor(uprId);
        }

        public object clone()
        {
            return Self.clone();
        }

        public void execute(BatchableContext BC, List<SObject> scope)
        {
            Self.execute(BC, scope);
        }

        public void finish(BatchableContext BC)
        {
            Self.finish(BC);
        }

        public QueryLocator start(BatchableContext BC)
        {
            return Self.start(BC);
        }
    }
}
