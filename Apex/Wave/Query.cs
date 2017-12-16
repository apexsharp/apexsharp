namespace Apex.Wave
{
    using ApexSharp.Implementation;
    using System;

    public class Query
    {
        // infrastructure
        public Query(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Query));
            }
        }

        // API
        public Query()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static string execute(string saql)
        {
            return Implementation.execute(saql);
        }
    }
}
