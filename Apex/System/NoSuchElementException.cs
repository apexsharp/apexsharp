namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class NoSuchElementException : Exception
    {
        // infrastructure
        public NoSuchElementException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NoSuchElementException));
            }
        }

        // API
        public NoSuchElementException()
        {
            Self = Implementation.Constructor();
        }

        public NoSuchElementException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public NoSuchElementException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public NoSuchElementException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
