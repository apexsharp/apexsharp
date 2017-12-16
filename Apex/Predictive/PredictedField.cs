namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class PredictedField
    {
        // infrastructure
        public PredictedField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PredictedField));
            }
        }

        // API
        public PredictedField()
        {
            Self = Implementation.Constructor();
        }

        public PredictedFieldType getType()
        {
            return Self.getType();
        }
    }
}