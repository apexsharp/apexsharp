namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class StringPredictedField
    {
        // infrastructure
        public StringPredictedField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StringPredictedField));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getPointEstimate()
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