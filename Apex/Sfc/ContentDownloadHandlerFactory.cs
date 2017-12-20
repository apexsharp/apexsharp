namespace Apex.Sfc
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_Sfc_ContentDownloadHandlerFactory.htm#apex_interface_Sfc_ContentDownloadHandlerFactory
    /// </summary>
    public interface ContentDownloadHandlerFactory
    {
        ContentDownloadHandler getContentDownloadHandler(List<ID> var1, ContentDownloadContext var2);
    }
}
