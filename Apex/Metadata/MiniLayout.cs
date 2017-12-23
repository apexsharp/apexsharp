namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_MiniLayout.htm#apex_class_Metadata_MiniLayout
    /// </summary>
    public class MiniLayout
    {
        // infrastructure
        public MiniLayout(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MiniLayout));
            }
        }

        // API
        List<string> fields
        {
            get
            {
                return Self.fields;
            }
            set
            {
                Self.fields = value;
            }
        }

        List<RelatedListItem> relatedLists
        {
            get
            {
                return Self.relatedLists;
            }
            set
            {
                Self.relatedLists = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public MiniLayout()
        {
            Self = Implementation.Constructor();
        }
    }
}
