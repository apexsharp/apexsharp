namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SessionCacheNoSessionException : Exception
    {
        // infrastructure
        public SessionCacheNoSessionException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SessionCacheNoSessionException));
            }
        }

        // API
        public SessionCacheNoSessionException()
        {
            Self = Implementation.Constructor();
        }

        public SessionCacheNoSessionException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SessionCacheNoSessionException(string msg)
        {
            Self = Implementation.Constructor(msg);
        }

        public SessionCacheNoSessionException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
