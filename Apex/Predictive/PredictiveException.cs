namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class PredictiveException : Exception
    {
        // infrastructure
        public PredictiveException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PredictiveException));
            }
        }

        // API
        public PredictiveException()
        {
            Self = Implementation.Constructor();
        }

        public PredictiveException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public PredictiveException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}