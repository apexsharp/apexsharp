namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidParamException : Exception
    {
        // infrastructure
        public InvalidParamException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidParamException));
            }
        }

        // API
        public InvalidParamException()
        {
            Self = Implementation.Constructor();
        }

        public InvalidParamException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidParamException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidParamException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
