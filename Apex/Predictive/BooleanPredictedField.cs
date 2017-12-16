namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class BooleanPredictedField
    {
        // infrastructure
        public BooleanPredictedField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BooleanPredictedField));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public bool getPointEstimate()
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