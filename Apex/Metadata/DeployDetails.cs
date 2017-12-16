namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_DeployDetails.htm#apex_class_Metadata_DeployDetails
    /// </summary>
    public class DeployDetails
    {
        // infrastructure
        public DeployDetails(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DeployDetails));
            }
        }

        // API
        List<DeployMessage> componentFailures
        {
            get
            {
                return Self.componentFailures;
            }
            set
            {
                Self.componentFailures = value;
            }
        }

        List<DeployMessage> componentSuccesses
        {
            get
            {
                return Self.componentSuccesses;
            }
            set
            {
                Self.componentSuccesses = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public DeployDetails()
        {
            Implementation.Constructor();
        }
    }
}
