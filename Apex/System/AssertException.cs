namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AssertException : Exception
    {
        // infrastructure
        public AssertException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AssertException));
            }
        }

        // API
        public AssertException()
        {
            Self = Implementation.Constructor();
        }

        public AssertException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public AssertException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public AssertException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
