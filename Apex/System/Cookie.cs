namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_sites_cookie.htm#apex_classes_sites_cookie
    /// </summary>
    public class Cookie
    {
        // infrastructure
        public Cookie(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Cookie));
            }
        }

        // API
        public Cookie(string name, string value, string path, int maxAge, bool isSecure)
        {
            Self = Implementation.Constructor(name, value, path, maxAge, isSecure);
        }

        public string getDomain()
        {
            return Self.getDomain();
        }

        public int getMaxAge()
        {
            return Self.getMaxAge();
        }

        public string getName()
        {
            return Self.getName();
        }

        public string getPath()
        {
            return Self.getPath();
        }

        public string getValue()
        {
            return Self.getValue();
        }

        public bool isSecure()
        {
            return Self.isSecure();
        }
    }
}
