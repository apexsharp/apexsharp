namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TypeException : Exception
    {
        // infrastructure
        public TypeException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TypeException));
            }
        }

        // API
        public TypeException()
        {
            Self = Implementation.Constructor();
        }

        public TypeException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public TypeException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public TypeException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
