namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RateLimitException
    {
        // infrastructure
        public RateLimitException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RateLimitException));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getErrorCode()
        {
            return Self.getErrorCode();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}
