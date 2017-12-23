namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SearchException : Exception
    {
        // infrastructure
        public SearchException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SearchException));
            }
        }

        // API
        public SearchException()
        {
            Self = Implementation.Constructor();
        }

        public SearchException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SearchException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SearchException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
