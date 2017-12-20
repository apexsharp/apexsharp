namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidReadOnlyUserDmlException : Exception
    {
        // infrastructure
        public InvalidReadOnlyUserDmlException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidReadOnlyUserDmlException));
            }
        }

        // API
        public InvalidReadOnlyUserDmlException()
        {
            Self = Implementation.Constructor();
        }

        public InvalidReadOnlyUserDmlException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidReadOnlyUserDmlException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidReadOnlyUserDmlException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
