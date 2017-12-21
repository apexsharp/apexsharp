using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(RestResponse))]
    public class RestResponseImplementation
    {
        // Self

        public class RestResponseInstance
        {
            public static implicit operator RestResponse(RestResponseInstance self) => new RestResponse(self);

            public Map<string, string> headers { get; set; }

            public Blob responseBody { get; set; }

            public int statusCode { get; set; }

            public void addHeader(string name, string value) => headers.put(name, value);

            public RestResponse clone() => new RestResponseInstance
            {
                headers = headers,
                responseBody = responseBody,
                statusCode = statusCode,
            };
        }

        // Implementation

        public dynamic Constructor() => new RestResponseInstance();
    }
}
