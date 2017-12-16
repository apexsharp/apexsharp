namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_ExternalEmailService_static_methods.htm#apex_ConnectAPI_ExternalEmailService_static_methods
    /// </summary>
    public class ExternalEmailServices
    {
        // infrastructure
        public ExternalEmailServices(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ExternalEmailServices));
            }
        }

        // API
        public static UserOauthInfo getUserOauthInfo(string landingPage)
        {
            return Implementation.getUserOauthInfo(landingPage);
        }
    }
}
