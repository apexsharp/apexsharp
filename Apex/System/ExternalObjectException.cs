namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ExternalObjectException : Exception
    {
        // infrastructure
        public ExternalObjectException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ExternalObjectException));
            }
        }

        // API
        public ExternalObjectException()
        {
            Self = Implementation.Constructor();
        }

        public ExternalObjectException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ExternalObjectException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ExternalObjectException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
