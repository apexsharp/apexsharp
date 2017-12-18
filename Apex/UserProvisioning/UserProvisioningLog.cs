namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_userprovisioning_userprovisioninglog.htm#apex_class_UserProvisioning_UserProvisioningLog
    /// </summary>
    public class UserProvisioningLog
    {
        // infrastructure
        public UserProvisioningLog(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserProvisioningLog));
            }
        }

        // API
        public void log(string userProvisioningRequestId, string details)
        {
            Self.log(userProvisioningRequestId, details);
        }

        public void log(string userProvisioningRequestId, string status, string details)
        {
            Self.log(userProvisioningRequestId, status, details);
        }

        public void log(string userProvisioningRequestId, string externalUserId, string externalUserName, string userId, string details)
        {
            Self.log(userProvisioningRequestId, externalUserId, externalUserName, userId, details);
        }

        public UserProvisioningLog()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
