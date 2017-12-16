namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class PresenceReason
    {
        // infrastructure
        public PresenceReason(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PresenceReason));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public ReasonType getType()
        {
            return Self.getType();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}