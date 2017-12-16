namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SfdcOps
    {
        // infrastructure
        public SfdcOps(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SfdcOps));
            }
        }

        // API
        public SfdcOps()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static Map<string, string> getCustomerInfo(string userName)
        {
            return Implementation.getCustomerInfo(userName);
        }

        public static Map<string, string> getCustomerInfo(string orgId, string userId)
        {
            return Implementation.getCustomerInfo(orgId, userId);
        }
    }
}
