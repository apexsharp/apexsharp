namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class Reason
    {
        // infrastructure
        public Reason(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Reason));
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