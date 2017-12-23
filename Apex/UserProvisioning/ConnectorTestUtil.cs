namespace Apex.UserProvisioning
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ConnectorTestUtil
    {
        // infrastructure
        public ConnectorTestUtil(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ConnectorTestUtil));
            }
        }

        // API
        public ConnectorTestUtil()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static ConnectedApplication createConnectedApp(string connectedAppName)
        {
            return Implementation.createConnectedApp(connectedAppName);
        }
    }
}
