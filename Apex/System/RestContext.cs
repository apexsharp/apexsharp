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
        public RestRequest request
        {
            get
            {
                return Self.request;
            }
            set
            {
                Self.request = value;
            }
        }

        public RestResponse response
        {
            get
            {
                return Self.response;
            }
            set
            {
                Self.response = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
