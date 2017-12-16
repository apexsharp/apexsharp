namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_multistaticresourcecalloutmock.htm#apex_methods_system_multistaticresourcecalloutmock
    /// </summary>
    public class MultiStaticResourceCalloutMock
    {
        // infrastructure
        public MultiStaticResourceCalloutMock(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MultiStaticResourceCalloutMock));
            }
        }

        // API
        public MultiStaticResourceCalloutMock()
        {
            Implementation.Constructor();
        }

        public void setHeader(string headerName, string headerValue)
        {
            Self.setHeader(headerName, headerValue);
        }

        public void setStaticResource(string endpoint, string resourceName)
        {
            Self.setStaticResource(endpoint, resourceName);
        }

        public void setStatus(string httpStatus)
        {
            Self.setStatus(httpStatus);
        }

        public void setStatusCode(int httpStatusCode)
        {
            Self.setStatusCode(httpStatusCode);
        }

        public object clone()
        {
            return Self.clone();
        }

        public HttpResponse respond(HttpRequest request)
        {
            return Self.respond(request);
        }
    }
}
