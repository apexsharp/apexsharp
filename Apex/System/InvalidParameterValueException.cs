namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidParameterValueException : Exception
    {
        // infrastructure
        public InvalidParameterValueException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidParameterValueException));
            }
        }

        // API
        public InvalidParameterValueException(string param1, string param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
