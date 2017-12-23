namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class RelatedField
    {
        // infrastructure
        public RelatedField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RelatedField));
            }
        }

        // API
        public RelatedField()
        {
            Self = Implementation.Constructor();
        }

        public RelatedField(string fieldName, double score, Reason reason)
        {
            Self = Implementation.Constructor(fieldName, score, reason);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getFieldName()
        {
            return Self.getFieldName();
        }

        public Reason getReason()
        {
            return Self.getReason();
        }

        public double getScore()
        {
            return Self.getScore();
        }

        public void setFieldName(string fieldName)
        {
            Self.setFieldName(fieldName);
        }

        public void setReason(Reason reason)
        {
            Self.setFieldName(reason);
        }

        public void setScore(double score)
        {
            Self.setScore(score);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}