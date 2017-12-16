namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ConnectApiException
    {
        // infrastructure
        public ConnectApiException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ConnectApiException));
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
