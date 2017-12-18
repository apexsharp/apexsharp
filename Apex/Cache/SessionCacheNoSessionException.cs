namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SessionCacheNoSessionException
    {
        // infrastructure
        public SessionCacheNoSessionException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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
