namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_Metadata_DeployCallback.htm#apex_interface_Metadata_DeployCallback
    /// </summary>
    public interface DeployCallback
    {
        void handleResult(DeployResult var1, DeployCallbackContext var2);
    }
}
