namespace Apex.DataSource 
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_enum_DataSource_AuthenticationProtocol.htm
    /// </summary>
    public enum AuthenticationProtocol
    {
        NONE,
        OAUTH,
        PASSWORD
    }
}
