namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_Provider.htm#apex_class_DataSource_Provider
    /// </summary>
    public class Provider
    {
        // infrastructure
        public Provider(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Provider));
            }
        }

        // API
        public List<AuthenticationCapability> getAuthenticationCapabilities()
        {
            return Self.getAuthenticationCapabilities();
        }

        public List<Capability> getCapabilities()
        {
            return Self.getCapabilities();
        }

        public Connection getConnection(ConnectionParams connectionParams)
        {
            return Self.getConnection(connectionParams);
        }
    }
}
