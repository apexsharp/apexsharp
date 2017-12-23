namespace Apex.Wave
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class QueryBuilderValidationUtil
    {
        // infrastructure
        public QueryBuilderValidationUtil(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueryBuilderValidationUtil));
            }
        }

        // API
        public QueryBuilderValidationUtil()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
