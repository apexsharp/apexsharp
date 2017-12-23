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
    public class LinkingBatchable
    {
        // infrastructure
        public LinkingBatchable(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LinkingBatchable));
            }
        }

        // API
        public LinkingBatchable(string uprId)
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

        public string getFlowName()
        {
            return Self.getFlowName();
        }

        public string getFlowNamespace()
        {
            return Self.getFlowNamespace();
        }

        public bool hasFlow()
        {
            return Self.hasFlow();
        }

        public bool hasFlowOrApex()
        {
            return Self.hasFlowOrApex();
        }

        public QueryLocator start(BatchableContext BC)
        {
            return Self.start(BC);
        }
    }
}
