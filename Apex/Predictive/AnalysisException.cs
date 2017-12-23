namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class AnalysisException : Exception
    {
        // infrastructure
        public AnalysisException(dynamic self)
        {
            Self = self;
        }

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
    }
}