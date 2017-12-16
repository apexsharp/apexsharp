namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PlatformCacheDelegateWrapper
    {
        // infrastructure
        public PlatformCacheDelegateWrapper(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PlatformCacheDelegateWrapper));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}
