namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class QueryException : Exception
    {
        // infrastructure
        public QueryException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueryException));
            }
        }

        // API
        public QueryException()
        {
            Self = Implementation.Constructor();
        }

        public QueryException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public QueryException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}