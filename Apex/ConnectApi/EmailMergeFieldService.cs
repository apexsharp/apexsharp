namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_EmailMergeFieldService_static_methods.htm#apex_ConnectAPI_EmailMergeFieldService_static_methods
    /// </summary>
    public class EmailMergeFieldService
    {
        // infrastructure
        public EmailMergeFieldService(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailMergeFieldService));
            }
        }

        // API
        public static EmailMergeFieldInfo getMergeFields(List<string> objectApiNames)
        {
            return Implementation.getMergeFields(objectApiNames);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
