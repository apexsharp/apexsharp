namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PlatformCacheInvalidOperationException
    {
        // infrastructure
        public PlatformCacheInvalidOperationException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PlatformCacheInvalidOperationException));
            }
        }

        // API
        public PlatformCacheInvalidOperationException()
        {
            Self = Implementation.Constructor();
        }

        public PlatformCacheInvalidOperationException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public PlatformCacheInvalidOperationException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public PlatformCacheInvalidOperationException(string param1, Exception param2)
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
