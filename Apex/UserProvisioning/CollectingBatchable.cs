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
    public class CollectingBatchable
    {
        // infrastructure
        public CollectingBatchable(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CollectingBatchable));
            }
        }

        // API
        object nextReconOffset
        {
            get
            {
                return Self.nextReconOffset;
            }
            set
            {
                Self.nextReconOffset = value;
            }
        }

        object reconOffset
        {
            get
            {
                return Self.reconOffset;
            }
            set
            {
                Self.reconOffset = value;
            }
        }

        object status
        {
            get
            {
                return Self.status;
            }
            set
            {
                Self.status = value;
            }
        }

        public CollectingBatchable(string reconOffset, string uprId, string connectedAppId)
        {
            Implementation.Constructor(reconOffset, uprId, connectedAppId);
        }

        public object clone()
        {
            return Self.clone();
        }

        public void execute(BatchableContext BC, List<UserProvisioningRequest> scope)
        {
            Self.execute(BC, scope);
        }

        public void finish(BatchableContext BC)
        {
            Self.finish(BC);
        }

        public Map<string, object> flowInputPreprocessing(Map<string, object> myMap)
        {
            return Self.flowInputPreprocessing(myMap);
        }

        public void flowPostProcessing(ProvisioningProcessHandlerOutput provOutput, SObject thisUPR)
        {
            Self.flowPostProcessing(provOutput, thisUPR);
        }

        public string getEventPrefix()
        {
            return Self.getEventPrefix();
        }

        public string getFlowName()
        {
            return Self.getFlowName();
        }

        public string getFlowNamespace()
        {
            return Self.getFlowNamespace();
        }

        public List<SObject> getPerBatchUPL()
        {
            return Self.getPerBatchUPL();
        }

        public List<UserProvisioningRequest> getPerBatchUPR()
        {
            return Self.getPerBatchUPR();
        }

        public Map<ID, SObject> getUprToNewUplMap()
        {
            return Self.getUprToNewUplMap();
        }

        public bool hasFlow()
        {
            return Self.hasFlow();
        }

        public bool hasFlowOrApex()
        {
            return Self.hasFlowOrApex();
        }

        public void postBatchProcessing()
        {
            Self.postBatchProcessing();
        }

        public QueryLocator start(BatchableContext BC)
        {
            return Self.start(BC);
        }
    }
}
