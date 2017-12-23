namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Wave_static_methods.htm#apex_ConnectAPI_Wave_static_methods
    /// </summary>
    public class Wave
    {
        // infrastructure
        public Wave(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Wave));
            }
        }

        // API
        public LiteralJson executeQuery(string query)
        {
            return Self.executeQuery(query);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static LiteralJson executeQueryByName(string name)
        {
            return Implementation.executeQueryByName(name);
        }
    }
}
