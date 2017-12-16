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
            Implementation.Constructor();
        }

        public SessionCacheNoSessionException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public SessionCacheNoSessionException(string msg)
        {
            Implementation.Constructor(msg);
        }

        public SessionCacheNoSessionException(string param1, Exception param2)
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
