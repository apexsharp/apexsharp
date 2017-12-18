namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class OrgCacheException
    {
        // infrastructure
        public OrgCacheException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(OrgCacheException));
            }
        }

        // API
        public OrgCacheException()
        {
            Self = Implementation.Constructor();
        }

        public OrgCacheException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public OrgCacheException(string msg)
        {
            Self = Implementation.Constructor(msg);
        }

        public OrgCacheException(string param1, Exception param2)
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
