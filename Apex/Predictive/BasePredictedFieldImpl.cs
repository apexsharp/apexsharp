namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class BasePredictedFieldImpl
    {
        // infrastructure
        public BasePredictedFieldImpl(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BasePredictedFieldImpl));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}