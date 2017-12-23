using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(RestContext))]
    public class RestContextImplementation
    {
        // Self

        public class RestContextInstance
        {
            public static implicit operator RestContext(RestContextInstance self) => new RestContext(self);

            public RestContext clone() => new RestContextInstance();
        }

        // Implementation

        public dynamic Constructor() => new RestContextInstance();

        public RestRequest request { get; set; }

        public RestResponse response { get; set; }
    }
}
