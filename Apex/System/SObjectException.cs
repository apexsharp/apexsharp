namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SObjectException : Exception
    {
        // infrastructure
        public SObjectException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SObjectException));
            }
        }

        // API
        public SObjectException()
        {
            Self = Implementation.Constructor();
        }

        public SObjectException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SObjectException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SObjectException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
