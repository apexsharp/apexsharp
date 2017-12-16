namespace Apex.Process
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_Process_Plugin.htm#apex_interface_Process_Plugin
    /// </summary>
    public interface Plugin
    {
        PluginDescribeResult describe();

        PluginResult invoke(PluginRequest request);
    }
}
