namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_RelatedContentItem.htm#apex_class_Metadata_RelatedContentItem
    /// </summary>
    public class RelatedContentItem
    {
        // infrastructure
        public RelatedContentItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RelatedContentItem));
            }
        }

        // API
        LayoutItem layoutItem
        {
            get
            {
                return Self.layoutItem;
            }
            set
            {
                Self.layoutItem = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public RelatedContentItem()
        {
            Implementation.Constructor();
        }
    }
}
