namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class FieldTreatment
    {
        // infrastructure
        public FieldTreatment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FieldTreatment));
            }
        }

        // API
        public FieldTreatmentType getType()
        {
            return Self.getType();
        }
    }
}