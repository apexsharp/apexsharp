namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class DatePredictedField
    {
        // infrastructure
        public DatePredictedField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DatePredictedField));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public Date getPointEstimate()
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