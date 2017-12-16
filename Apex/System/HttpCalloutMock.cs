namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_httpcalloutmock.htm#apex_interface_httpcalloutmock
    /// </summary>
    public interface HttpCalloutMock
    {
        HttpResponse respond(HttpRequest request);
    }
}
