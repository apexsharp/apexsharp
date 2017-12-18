namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Org62Ops
    {
        // infrastructure
        public Org62Ops(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Org62Ops));
            }
        }

        // API
        public Org62Ops()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static string executeUsingInternalRestService(string targetOrgId, string url)
        {
            return Implementation.executeUsingInternalRestService(targetOrgId, url);
        }

        public static string getSfdcBtLoginUrl(string caseId, string landingUrl)
        {
            return Implementation.getSfdcBtLoginUrl(caseId, landingUrl);
        }
    }
}
