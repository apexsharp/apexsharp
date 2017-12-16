namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Dom;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_restful_http_httprequest.htm#apex_classes_restful_http_httprequest
    /// </summary>
    public class HttpRequest
    {
        // infrastructure
        public HttpRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(HttpRequest));
            }
        }

        // API
        public HttpRequest()
        {
            Implementation.Constructor();
        }

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

        public bool getCompressed()
        {
            return Self.getCompressed();
        }

        public string getEndpoint()
        {
            return Self.getEndpoint();
        }

        public string getHeader(string key)
        {
            return Self.getHeader(key);
        }

        public string getMethod()
        {
            return Self.getMethod();
        }

        public void setBody(string body)
        {
            Self.setBody(body);
        }

        public void setBodyAsBlob(Blob body)
        {
            Self.setBodyAsBlob(body);
        }

        public void setBodyDocument(Document document)
        {
            Self.setBodyDocument(document);
        }

        public void setClientCertificate(string clientCert, string password)
        {
            Self.setClientCertificate(clientCert, password);
        }

        public void setClientCertificateName(string certDevName)
        {
            Self.setClientCertificateName(certDevName);
        }

        public void setCompressed(bool flag)
        {
            Self.setCompressed(flag);
        }

        public void setEndpoint(string endpoint)
        {
            Self.setEndpoint(endpoint);
        }

        public void setHeader(string key, string value)
        {
            Self.setHeader(key, value);
        }

        public void setMethod(string method)
        {
            Self.setMethod(method);
        }

        public void setTimeout(int timeout)
        {
            Self.setTimeout(timeout);
        }

        public string toString()
        {
            return Self.toString();
        }

        public void setBodyDocument(object body)
        {
            Self.setBodyDocument(body);
        }
    }
}
