namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class RelatedResult
    {
        // infrastructure
        public RelatedResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RelatedResult));
            }
        }

        // API
        public RelatedResult()
        {
            Self = Implementation.Constructor();
        }

        public RelatedResult(List<RelatedField> relatedFields, List<string> warnings)
        {
            Self = Implementation.Constructor(relatedFields, warnings);
        }

        public object clone()
        {
            return Self.clone();
        }

        public List<RelatedField> getRelatedFields()
        {
            return Self.getRelatedFields();
        }

        public List<string> getWarnings()
        {
            return Self.getWarnings();
        }

        public void setRelatedFields(List<RelatedField> relatedFields)
        {
            Self.setRelatedFields(relatedFields);
        }

        public void setWarnings(List<string> warnings)
        {
            Self.setWarnings(warnings);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}