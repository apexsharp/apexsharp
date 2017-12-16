namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_JWS.htm#apex_class_Auth_JWS
    /// </summary>
    public class JWS
    {
        // infrastructure
        public JWS(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(JWS));
            }
        }

        // API
        public JWS(JWT jwt, string certDevName)
        {
            Implementation.Constructor(jwt, certDevName);
        }

        public JWS(string payload, string certDevName)
        {
            Implementation.Constructor(payload, certDevName);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getCompactSerialization()
        {
            return Self.getCompactSerialization();
        }
    }
}
