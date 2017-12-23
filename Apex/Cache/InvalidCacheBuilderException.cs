namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidCacheBuilderException : Exception
    {
        // infrastructure
        public InvalidCacheBuilderException(dynamic self)
        {
            Self = self;
        }

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
            Self = Implementation.Constructor();
        }

        public InvalidCacheBuilderException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidCacheBuilderException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidCacheBuilderException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
