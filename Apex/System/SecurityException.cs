namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SecurityException : Exception
    {
        // infrastructure
        public SecurityException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SecurityException));
            }
        }

        // API
        public SecurityException()
        {
            Self = Implementation.Constructor();
        }

        public SecurityException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SecurityException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SecurityException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
