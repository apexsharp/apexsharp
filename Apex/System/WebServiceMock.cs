namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_webservicemock.htm#apex_interface_webservicemock
    /// </summary>
    public interface WebServiceMock
    {
        void doInvoke(object stub, object soapRequest, Map<string, object> responseMap, string endpoint, string soapAction, string requestName, string responseNamespace, string responseName, string responseType);
    }
}
