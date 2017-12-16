namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class TimeDeltaFieldTreatment
    {
        // infrastructure
        public TimeDeltaFieldTreatment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TimeDeltaFieldTreatment));
            }
        }

        // API
        public TimeDeltaFieldTreatment()
        {
            Self = Implementation.Constructor();
        }

        public TimeDeltaFieldTreatment(string fromField)
        {
            Self = Implementation.Constructor(fromField);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getFromField()
        {
            return Self.getFromField();
        }

        public FieldTreatmentType getType()
        {
            return Self.getType();
        }

        public void setFromField(string fromField)
        {
            Self.setFromField(fromField);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}