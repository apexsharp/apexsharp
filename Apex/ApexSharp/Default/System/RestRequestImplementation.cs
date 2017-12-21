using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(RestRequest))]
    public class RestRequestImplementation
    {
        // Self

        public class RestRequestInstance
        {
            public static implicit operator RestRequest(RestRequestInstance self) => new RestRequest(self);

            private dynamic NotImplemented { get; } = new StubImplementation(typeof(RestRequest));

            public Map<string, string> headers { get; set; } = new Map<string, string>();

            public string httpMethod { get; set; }

            public Map<string, string> @params { get; set; } = new Map<string, string>();

            public string remoteAddress { get; set; }

            public Blob requestBody { get; set; }

            public string requestURI { get; set; }

            public string resourcePath { get; set; }

            public void addHeader(string name, string value) => headers.put(name, value);

            public void addParameter(string name, string value) => @params.put(name, value);

            public RestRequest clone() => new RestRequestInstance
            {
                headers = headers,
                httpMethod = httpMethod,
                @params = @params,
                requestBody = requestBody,
                requestURI = requestURI,
                resourcePath = resourcePath,
            };
        }

        // Implementation

        public dynamic Constructor() => new RestRequestInstance();
    }
}
