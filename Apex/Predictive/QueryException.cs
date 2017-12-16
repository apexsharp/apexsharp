namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class QueryException
    {
        // infrastructure
        public QueryException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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

        public object clone()
        {
            return Self.clone();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}