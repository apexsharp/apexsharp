namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class PredictiveException
    {
        // infrastructure
        public PredictiveException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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