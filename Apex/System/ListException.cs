namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ListException : Exception
    {
        // infrastructure
        public ListException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ListException));
            }
        }

        // API
        public ListException()
        {
            Self = Implementation.Constructor();
        }

        public ListException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ListException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ListException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
