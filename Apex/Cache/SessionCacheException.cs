namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SessionCacheException : Exception
    {
        // infrastructure
        public SessionCacheException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SessionCacheException));
            }
        }

        // API
        public SessionCacheException()
        {
            Self = Implementation.Constructor();
        }

        public SessionCacheException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SessionCacheException(string msg)
        {
            Self = Implementation.Constructor(msg);
        }

        public SessionCacheException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
