namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class PredictedResult
    {
        // infrastructure
        public PredictedResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PredictedResult));
            }
        }

        // API
        public PredictedResult()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public Map<String, PredictedField> getPredictedFields()
        {
            return Self.getPredictedFields();
        }

        public List<string> getWarnings()
        {
            return Self.getWarnings();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}