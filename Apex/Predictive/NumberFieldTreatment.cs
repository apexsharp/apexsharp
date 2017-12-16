namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class NumberFieldTreatment
    {
        // infrastructure
        public NumberFieldTreatment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NumberFieldTreatment));
            }
        }

        // API
        public NumberFieldTreatment()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public FieldTreatmentType getType()
        {
            return Self.getType();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}