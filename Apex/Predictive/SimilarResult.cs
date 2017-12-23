namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class SimilarResult
    {
        // infrastructure
        public SimilarResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SimilarResult));
            }
        }

        // API
        public SimilarResult()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public List<SimilarRecord> getSimilarRecords()
        {
            return Self.getSimilarRecords();
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