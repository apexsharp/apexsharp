namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class ObjectTreatment
    {
        // infrastructure
        public ObjectTreatment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ObjectTreatment));
            }
        }

        // API
        public ObjectTreatment()
        {
            Self = Implementation.Constructor();
        }

        public ObjectTreatment(Map<String, FieldTreatment> fieldTreatments)
        {
            Self = Implementation.Constructor(fieldTreatments);
        }

        public object clone()
        {
            return Self.clone();
        }

        public Map<String, FieldTreatment> getFieldTreatments()
        {
            return Self.getFieldTreatments();
        }

        public void setFieldTreatments(Map<String, FieldTreatment> fieldTreatments)
        {
            Self.setFieldTreatments(fieldTreatments);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}