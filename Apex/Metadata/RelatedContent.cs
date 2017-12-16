namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_RelatedContent.htm#apex_class_Metadata_RelatedContent
    /// </summary>
    public class RelatedContent
    {
        // infrastructure
        public RelatedContent(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RelatedContent));
            }
        }

        // API
        List<RelatedContentItem> relatedContentItems
        {
            get
            {
                return Self.relatedContentItems;
            }
            set
            {
                Self.relatedContentItems = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public RelatedContent()
        {
            Implementation.Constructor();
        }
    }
}
