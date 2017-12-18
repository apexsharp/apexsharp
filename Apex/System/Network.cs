namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_network.htm#apex_classes_network
    /// </summary>
    public class Network
    {
        // infrastructure
        public Network(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Network));
            }
        }

        // API
        public Network()
        {
            Self = Implementation.Constructor();
        }

        public static string communitiesLanding()
        {
            return Implementation.communitiesLanding();
        }

        public static PageReference forwardToAuthPage(string startURL)
        {
            return Implementation.forwardToAuthPage(startURL);
        }

        public static string getLoginUrl(string networkId)
        {
            return Implementation.getLoginUrl(networkId);
        }

        public static string getLogoutUrl(string networkId)
        {
            return Implementation.getLogoutUrl(networkId);
        }

        public static string getNetworkId()
        {
            return Implementation.getNetworkId();
        }

        public static string getSelfRegUrl(string networkId)
        {
            return Implementation.getSelfRegUrl(networkId);
        }

        public static int loadAllPackageDefaultNetworkDashboardSettings()
        {
            return Implementation.loadAllPackageDefaultNetworkDashboardSettings();
        }

        public static int loadAllPackageDefaultNetworkPulseSettings()
        {
            return Implementation.loadAllPackageDefaultNetworkPulseSettings();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static PageReference forwardToAuthPage(string startUrl, string displayType)
        {
            return Implementation.forwardToAuthPage(startUrl, displayType);
        }

        public static int loadAllPackageDefaultNetworkWorkspaceMetricSettings()
        {
            return Implementation.loadAllPackageDefaultNetworkWorkspaceMetricSettings();
        }
    }
}
