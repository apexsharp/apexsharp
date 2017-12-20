namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_restcontext.htm#apex_methods_system_restcontext
    /// </summary>
    public class RestContext
    {
        // infrastructure
        public RestContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RestContext));
            }
        }

        // API
        public static RestRequest request
        {
            get
            {
                return Implementation.request;
            }
            set
            {
                Implementation.request = value;
            }
        }

        public static RestResponse response
        {
            get
            {
                return Implementation.response;
            }
            set
            {
                Implementation.response = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
