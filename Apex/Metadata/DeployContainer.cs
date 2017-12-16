namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_DeployContainer.htm#apex_class_Metadata_DeployContainer
    /// </summary>
    public class DeployContainer
    {
        // infrastructure
        public DeployContainer(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DeployContainer));
            }
        }

        // API
        public void addMetadata(Metadata md)
        {
            Self.addMetadata(md);
        }

        public object clone()
        {
            return Self.clone();
        }

        public List<Metadata> getMetadata()
        {
            return Self.getMetadata();
        }

        public bool removeMetadata(Metadata md)
        {
            return Self.removeMetadata(md);
        }

        public bool removeMetadataByFullName(string fullName)
        {
            return Self.removeMetadataByFullName(fullName);
        }

        public DeployContainer()
        {
            Implementation.Constructor();
        }
    }
}
