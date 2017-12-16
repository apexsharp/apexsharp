namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_reports_NotificationAction.htm#apex_interface_reports_NotificationAction
    /// </summary>
    public interface NotificationAction
    {
        void execute(NotificationActionContext context);
    }
}
