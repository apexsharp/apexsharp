namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_QuickAction_QuickActionDefaultsHandler.htm#apex_interface_QuickAction_QuickActionDefaultsHandler
    /// </summary>
    public interface QuickActionDefaultsHandler
    {
        void onInitDefaults(QuickActionDefaults[] actionDefaults);

        void onInitDefaults(List<QuickActionDefaults> param1);
    }
}
