namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Process;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_UserProvisioning_UserProvisioningPlugin.htm#apex_class_UserProvisioning_UserProvisioningPlugin
    /// </summary>
    public class UserProvisioningPlugin
    {
        // infrastructure
        public UserProvisioningPlugin(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserProvisioningPlugin));
            }
        }

        // API
        public PluginDescribeResult buildDescribeCall()
        {
            return Self.buildDescribeCall();
        }

        public PluginDescribeResult describe()
        {
            return Self.describe();
        }

        public string getPluginClassName()
        {
            return Self.getPluginClassName();
        }

        public PluginResult invoke(PluginRequest request)
        {
            return Self.invoke(request);
        }

        public UserProvisioningPlugin()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
