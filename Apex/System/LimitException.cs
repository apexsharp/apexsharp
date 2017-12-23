namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LimitException : Exception
    {
        // infrastructure
        public LimitException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LimitException));
            }
        }

        // API
        public LimitException()
        {
            Self = Implementation.Constructor();
        }

        public LimitException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public LimitException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public LimitException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
