namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_email_inbound_envelope.htm#apex_classes_email_inbound_envelope
    /// </summary>
    public class InboundEnvelope
    {
        // infrastructure
        public InboundEnvelope(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InboundEnvelope));
            }
        }

        // API
        string fromAddress
        {
            get
            {
                return Self.fromAddress;
            }
            set
            {
                Self.fromAddress = value;
            }
        }

        string toAddress
        {
            get
            {
                return Self.toAddress;
            }
            set
            {
                Self.toAddress = value;
            }
        }

        public InboundEnvelope()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
