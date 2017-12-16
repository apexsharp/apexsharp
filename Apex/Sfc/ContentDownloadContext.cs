namespace Apex.Sfc
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_enum_Sfc_ContentDownloadContext.htm
    /// </summary>
    public enum ContentDownloadContext
    {
        CHATTER,
        CONTENT,
        DELIVERY,
        MOBILE,
        REST_API,
        RETRIEVE,
        S1,
        SOQL
    }
}
