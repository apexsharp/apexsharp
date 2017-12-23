namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_System_Continuation.htm#apex_class_System_Continuation
    /// </summary>
    public class Continuation
    {
        // infrastructure
        public Continuation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Continuation));
            }
        }

        // API
        public Continuation(int timeout)
        {
            Self = Implementation.Constructor(timeout);
        }

        string continuationMethod
        {
            get
            {
                return Self.continuationMethod;
            }
            set
            {
                Self.continuationMethod = value;
            }
        }

        int timeout
        {
            get
            {
                return Self.timeout;
            }
            set
            {
                Self.timeout = value;
            }
        }

        object state
        {
            get
            {
                return Self.state;
            }
            set
            {
                Self.state = value;
            }
        }

        public string addHttpRequest(HttpRequest request)
        {
            return Self.addHttpRequest(request);
        }

        public Map<string, HttpRequest> getRequests()
        {
            return Self.getRequests();
        }

        public static HttpResponse getResponse(string requestLabel)
        {
            return Implementation.getResponse(requestLabel);
        }

        string ContinuationMethod
        {
            get
            {
                return Self.ContinuationMethod;
            }
            set
            {
                Self.ContinuationMethod = value;
            }
        }

        int Timeout
        {
            get
            {
                return Self.Timeout;
            }
            set
            {
                Self.Timeout = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
