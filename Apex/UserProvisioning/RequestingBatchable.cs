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
    public class RequestingBatchable
    {
        // infrastructure
        public RequestingBatchable(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RequestingBatchable));
            }
        }

        // API
        public RequestingBatchable(List<SObject> newRows)
        {
            Implementation.Constructor(newRows);
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

        public QueryLocator start(BatchableContext BC)
        {
            return Self.start(BC);
        }
    }
}
