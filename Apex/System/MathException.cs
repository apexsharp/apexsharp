namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MathException : Exception
    {
        // infrastructure
        public MathException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MathException));
            }
        }

        // API
        public MathException()
        {
            Self = Implementation.Constructor();
        }

        public MathException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public MathException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public MathException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
