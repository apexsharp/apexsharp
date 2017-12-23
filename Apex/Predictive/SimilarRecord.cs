namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class SimilarRecord
    {
        // infrastructure
        public SimilarRecord(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SimilarRecord));
            }
        }

        // API
        public SimilarRecord()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public ID getRecordId()
        {
            return Self.getRecordId();
        }

        public double getScore()
        {
            return Self.getScore();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}