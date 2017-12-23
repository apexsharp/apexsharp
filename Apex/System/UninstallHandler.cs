namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_uninstall_handler.htm#apex_uninstall_handler
    /// </summary>
    public interface UninstallHandler
    {
        void onUninstall(UninstallContext context);
    }
}
