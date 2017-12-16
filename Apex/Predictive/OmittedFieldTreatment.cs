namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class OmittedFieldTreatment
    {
        // infrastructure
        public OmittedFieldTreatment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(OmittedFieldTreatment));
            }
        }

        // API
        public OmittedFieldTreatment()
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