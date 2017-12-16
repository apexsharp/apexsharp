namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_System_FeatureManagement.htm#apex_class_System_FeatureManagement
    /// </summary>
    public class FeatureManagement
    {
        // infrastructure
        public FeatureManagement(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeatureManagement));
            }
        }

        // API
        public static void changeProtection(string apiName, string typeApiName, string protection)
        {
            Implementation.changeProtection(apiName, typeApiName, protection);
        }

        public static bool checkPackageBooleanValue(string apiName)
        {
            return Implementation.checkPackageBooleanValue(apiName);
        }

        public static Date checkPackageDateValue(string apiName)
        {
            return Implementation.checkPackageDateValue(apiName);
        }

        public static int checkPackageIntegerValue(string apiName)
        {
            return Implementation.checkPackageIntegerValue(apiName);
        }

        public static bool checkPermission(string apiName)
        {
            return Implementation.checkPermission(apiName);
        }

        public static void setPackageBooleanValue(string apiName, bool value)
        {
            Implementation.setPackageBooleanValue(apiName, value);
        }

        public static void setPackageDateValue(string apiName, Date value)
        {
            Implementation.setPackageDateValue(apiName, value);
        }

        public static void setPackageIntegerValue(string apiName, int value)
        {
            Implementation.setPackageIntegerValue(apiName, value);
        }

        public FeatureManagement()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
