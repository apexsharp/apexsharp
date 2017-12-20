namespace Apex.EventBus
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RetryableException : Exception
    {
        // infrastructure
        public RetryableException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RetryableException));
            }
        }

        // API
        public RetryableException()
        {
            Self = Implementation.Constructor();
        }

        public RetryableException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public RetryableException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public RetryableException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
