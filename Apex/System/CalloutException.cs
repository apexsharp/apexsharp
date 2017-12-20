namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CalloutException : Exception
    {
        // infrastructure
        public CalloutException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CalloutException));
            }
        }

        // API
        public CalloutException()
        {
            Self = Implementation.Constructor();
        }

        public CalloutException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public CalloutException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public CalloutException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
