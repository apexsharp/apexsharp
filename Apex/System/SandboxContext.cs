namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SandboxContext
    {
        // infrastructure
        public SandboxContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SandboxContext));
            }
        }

        // API
        public ID organizationId()
        {
            return Self.organizationId();
        }

        public ID sandboxId()
        {
            return Self.sandboxId();
        }

        public string sandboxName()
        {
            return Self.sandboxName();
        }
    }
}
