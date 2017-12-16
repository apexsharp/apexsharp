namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_SalesforceInbox_static_methods.htm#apex_ConnectAPI_SalesforceInbox_static_methods
    /// </summary>
    public class SalesforceInbox
    {
        // infrastructure
        public SalesforceInbox(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SalesforceInbox));
            }
        }

        // API
        public static ActivitySharingResult shareActivity(string activityId, ActivitySharingInput sharingInfo)
        {
            return Implementation.shareActivity(activityId, sharingInfo);
        }
    }
}
