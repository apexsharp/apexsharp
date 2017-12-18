namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_DeployCallbackContext.htm#apex_class_Metadata_DeployCallbackContext
    /// </summary>
    public class DeployCallbackContext
    {
        // infrastructure
        public DeployCallbackContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DeployCallbackContext));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public ID getCallbackJobId()
        {
            return Self.getCallbackJobId();
        }

        public DeployCallbackContext()
        {
            Self = Implementation.Constructor();
        }
    }
}
