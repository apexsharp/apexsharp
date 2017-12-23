namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class ObjectAnalysisService
    {
        // infrastructure
        public ObjectAnalysisService(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ObjectAnalysisService));
            }
        }

        // API
        public ObjectAnalysisService()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static ObjectAnalysis get(string objectName)
        {
            return Implementation.get(objectName);
        }

        public static List<ObjectAnalysis> getAll()
        {
            return Implementation.getAll();
        }
    }
}