namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Dom;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_restful_http_httpresponse.htm#apex_classes_restful_http_httpresponse
    /// </summary>
    public class HttpResponse
    {
        // infrastructure
        public HttpResponse(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(HttpResponse));
            }
        }

        // API
        public string getBody()
        {
            return Self.getBody();
        }

        public Blob getBodyAsBlob()
        {
            return Self.getBodyAsBlob();
        }

        public Document getBodyDocument()
        {
            return Self.getBodyDocument();
        }

        public string getHeader(string key)
        {
            return Self.getHeader(key);
        }

        public string[] getHeaderKeys()
        {
            return Self.getHeaderKeys();
        }

        public string getStatus()
        {
            return Self.getStatus();
        }

        public int getStatusCode()
        {
            return Self.getStatusCode();
        }

        public XmlStreamReader getXmlStreamReader()
        {
            return Self.getXmlStreamReader();
        }

        public void setBody(string body)
        {
            Self.setBody(body);
        }

        public void setBodyAsBlob(Blob body)
        {
            Self.setBodyAsBlob(body);
        }

        public void setHeader(string key, string value)
        {
            Self.setHeader(key, value);
        }

        public void setStatus(string status)
        {
            Self.setStatus(status);
        }

        public void setStatusCode(int statusCode)
        {
            Self.setStatusCode(statusCode);
        }

        public string toString()
        {
            return Self.toString();
        }

        public HttpResponse()
        {
            Self = Implementation.Constructor();
        }
    }
}
