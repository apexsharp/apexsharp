namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UserProvisioningProcessHandler
    {
        // infrastructure
        public UserProvisioningProcessHandler(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserProvisioningProcessHandler));
            }
        }

        // API
        public UserProvisioningProcessHandler()
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
