namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidCacheBuilderException
    {
        // infrastructure
        public InvalidCacheBuilderException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidCacheBuilderException));
            }
        }

        // API
        public InvalidCacheBuilderException()
        {
            Implementation.Constructor();
        }

        public InvalidCacheBuilderException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public InvalidCacheBuilderException(string param1)
        {
            Implementation.Constructor(param1);
        }

        public InvalidCacheBuilderException(string param1, Exception param2)
        {
            Implementation.Constructor(param1, param2);
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
