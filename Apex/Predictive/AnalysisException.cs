namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class AnalysisException
    {
        // infrastructure
        public AnalysisException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AnalysisException));
            }
        }

        // API
        public AnalysisException()
        {
            Self = Implementation.Constructor();
        }

        public AnalysisException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public AnalysisException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public AnalysisException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}