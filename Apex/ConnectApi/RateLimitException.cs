namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RateLimitException : Exception
    {
        // infrastructure
        public RateLimitException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RateLimitException));
            }
        }

        // API
        public string getErrorCode()
        {
            return Self.getErrorCode();
        }
    }
}
