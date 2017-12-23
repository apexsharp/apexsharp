namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidFilterException : Exception
    {
        // infrastructure
        public InvalidFilterException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidFilterException));
            }
        }

        // API
        public InvalidFilterException()
        {
            Self = Implementation.Constructor();
        }

        public InvalidFilterException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidFilterException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidFilterException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }

        public List<string> getFilterErrors()
        {
            return Self.getFilterErrors();
        }
    }
}
