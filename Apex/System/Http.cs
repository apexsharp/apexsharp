namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_restful_http_http.htm#apex_classes_restful_http_http
    /// </summary>
    public class Http
    {
        // infrastructure
        public Http(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Http));
            }
        }

        // API
        public HttpResponse send(HttpRequest request)
        {
            return Self.send(request);
        }

        public string toString()
        {
            return Self.toString();
        }

        public Http()
        {
            Implementation.Constructor();
        }

        public HttpResponse send(object request)
        {
            return Self.send(request);
        }
    }
}
