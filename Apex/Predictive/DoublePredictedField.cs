namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class DoublePredictedField
    {
        // infrastructure
        public DoublePredictedField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DoublePredictedField));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public double getPointEstimate()
        {
            return Self.getPointEstimate();
        }

        public PredictedFieldType getType()
        {
            return Self.getType();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}