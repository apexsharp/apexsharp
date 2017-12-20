namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AsyncException : Exception
    {
        // infrastructure
        public AsyncException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AsyncException));
            }
        }

        // API
        public AsyncException()
        {
            Self = Implementation.Constructor();
        }

        public AsyncException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public AsyncException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public AsyncException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
