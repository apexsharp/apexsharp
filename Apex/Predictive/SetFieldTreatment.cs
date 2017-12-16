namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class SetFieldTreatment
    {
        // infrastructure
        public SetFieldTreatment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SetFieldTreatment));
            }
        }

        // API
        public SetFieldTreatment()
        {
            Self = Implementation.Constructor();
        }

        public SetFieldTreatment(string bin)
        {
            Self = Implementation.Constructor(bin);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getBin()
        {
            return Self.getBin();
        }

        public FieldTreatmentType getType()
        {
            return Self.getType();
        }

        public void setBin(string bin)
        {
            Self.setBin(bin);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}