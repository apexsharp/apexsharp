namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class ObjectAnalysis
    {
        // infrastructure
        public ObjectAnalysis(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ObjectAnalysis));
            }
        }

        // API
        public ObjectAnalysis()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getObjectName()
        {
            return Self.getObjectName();
        }

        public SimilarResult findSimilar(Row target, string fieldName)
        {
            return Self.findSimilar(target, fieldName);
        }

        public ObjectRefreshStatus getRefreshStatus()
        {
            return Self.getRefreshStatus();
        }

        public PredictedResult predict(Row fixedApex, List<string> predict)
        {
            return Self.predict(fixedApex, predict);
        }

        public void refresh(ObjectTreatment objectTreatment)
        {
            Self.refresh(objectTreatment);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}