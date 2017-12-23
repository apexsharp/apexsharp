namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DummyConnectorApexHandler
    {
        // infrastructure
        public DummyConnectorApexHandler(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DummyConnectorApexHandler));
            }
        }

        // API
        public DummyConnectorApexHandler()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public ProvisioningProcessHandlerOutput invoke(ProvisioningProcessHandlerInput input)
        {
            return Self.invoke(input);
        }
    }
}
