namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_system_schedulablecontext.htm#apex_interface_system_schedulablecontext
    /// </summary>
    public interface SchedulableContext
    {
        ID getTriggerId();
    }
}
