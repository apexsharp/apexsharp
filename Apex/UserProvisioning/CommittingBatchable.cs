namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CommittingBatchable
    {
        // infrastructure
        public CommittingBatchable(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CommittingBatchable));
            }
        }

        // API
        public CommittingBatchable(string uprId)
        {
            Implementation.Constructor(uprId);
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
