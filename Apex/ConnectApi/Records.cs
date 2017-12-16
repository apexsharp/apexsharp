namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Records_static_methods.htm#apex_ConnectAPI_Records_static_methods
    /// </summary>
    public class Records
    {
        // infrastructure
        public Records(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Records));
            }
        }

        // API
        public static Motif getMotif(string communityId, string idOrPrefix)
        {
            return Implementation.getMotif(communityId, idOrPrefix);
        }

        public static BatchResult[] getMotifBatch(string communityId, List<string> idOrPrefixList)
        {
            return Implementation.getMotifBatch(communityId, idOrPrefixList);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
