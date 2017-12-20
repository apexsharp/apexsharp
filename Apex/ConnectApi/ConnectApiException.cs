namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ConnectApiException : Exception
    {
        // infrastructure
        public ConnectApiException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ConnectApiException));
            }
        }

        // API
        public string getErrorCode()
        {
            return Self.getErrorCode();
        }
    }
}
