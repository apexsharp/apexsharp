namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InboundEmailHandler
    {
        // infrastructure
        public InboundEmailHandler(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InboundEmailHandler));
            }
        }

        // API
        public InboundEmailResult handleInboundEmail(InboundEmail inboundEmail, InboundEnvelope inboundEnvelope)
        {
            return Self.handleInboundEmail(inboundEmail, inboundEnvelope);
        }
    }
}
