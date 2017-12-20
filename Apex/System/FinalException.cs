namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FinalException : Exception
    {
        // infrastructure
        public FinalException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FinalException));
            }
        }

        // API
        public FinalException()
        {
            Self = Implementation.Constructor();
        }

        public FinalException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public FinalException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public FinalException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
