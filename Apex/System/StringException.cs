namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class StringException : Exception
    {
        // infrastructure
        public StringException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StringException));
            }
        }

        // API
        public StringException()
        {
            Self = Implementation.Constructor();
        }

        public StringException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public StringException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public StringException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
