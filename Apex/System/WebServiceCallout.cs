namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_System_WebServiceCallout.htm#apex_class_System_WebServiceCallout
    /// </summary>
    public class WebServiceCallout
    {
        // infrastructure
        public WebServiceCallout(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(WebServiceCallout));
            }
        }

        // API
        public static void invoke(object stub, object request, Map<string, object> response, List<string> infoArray)
        {
            Implementation.invoke(stub, request, response, infoArray);
        }

        public static object beginInvoke(object stub, object request, object returnType, object continuation, List<string> info)
        {
            return Implementation.beginInvoke(stub, request, returnType, continuation, info);
        }

        public static object endInvoke(object future)
        {
            return Implementation.endInvoke(future);
        }
    }
}
