namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UnexpectedException : Exception
    {
        // infrastructure
        public UnexpectedException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UnexpectedException));
            }
        }

        // API
        public UnexpectedException()
        {
            Self = Implementation.Constructor();
        }

        public UnexpectedException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public UnexpectedException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public UnexpectedException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
