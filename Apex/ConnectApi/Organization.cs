namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Organization_static_methods.htm#apex_ConnectAPI_Organization_static_methods
    /// </summary>
    public class Organization
    {
        // infrastructure
        public Organization(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Organization));
            }
        }

        // API
        public static OrganizationSettings getSettings()
        {
            return Implementation.getSettings();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
