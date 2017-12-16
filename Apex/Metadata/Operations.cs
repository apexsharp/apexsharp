namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_Operations.htm#apex_class_Metadata_Operations
    /// </summary>
    public class Operations
    {
        // infrastructure
        public Operations(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Operations));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public static ID enqueueDeployment(DeployContainer container, DeployCallback callback)
        {
            return Implementation.enqueueDeployment(container, callback);
        }

        public static List<Metadata> retrieve(MetadataType type, List<string> fullNames)
        {
            return Implementation.retrieve(type, fullNames);
        }

        public Operations()
        {
            Implementation.Constructor();
        }
    }
}
