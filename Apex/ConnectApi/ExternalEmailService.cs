namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ExternalEmailService
    {
        // infrastructure
        public ExternalEmailService(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ExternalEmailService));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public static UserOauthInfo getUserOauthInfo(string landingPage)
        {
            return Implementation.getUserOauthInfo(landingPage);
        }
    }
}
