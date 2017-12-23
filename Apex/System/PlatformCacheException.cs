namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PlatformCacheException : Exception
    {
        // infrastructure
        public PlatformCacheException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PlatformCacheException));
            }
        }

        // API
        public PlatformCacheException()
        {
            Self = Implementation.Constructor();
        }

        public PlatformCacheException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public PlatformCacheException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public PlatformCacheException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
