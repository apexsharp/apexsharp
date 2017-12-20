namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidHeaderException : Exception
    {
        // infrastructure
        public InvalidHeaderException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidHeaderException));
            }
        }

        // API
        public InvalidHeaderException()
        {
            Self = Implementation.Constructor();
        }

        public InvalidHeaderException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidHeaderException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidHeaderException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
