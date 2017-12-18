namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FlowProvisionBase
    {
        // infrastructure
        public FlowProvisionBase(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FlowProvisionBase));
            }
        }

        // API
        public FlowProvisionBase(string uprId)
        {
            Self = Implementation.Constructor(uprId);
        }

        public object clone()
        {
            return Self.clone();
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
    }
}
