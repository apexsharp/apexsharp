namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_RelatedList.htm#apex_class_Metadata_RelatedList
    /// </summary>
    public class RelatedList
    {
        // infrastructure
        public RelatedList(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RelatedList));
            }
        }

        // API
        bool hideOnDetail
        {
            get
            {
                return Self.hideOnDetail;
            }
            set
            {
                Self.hideOnDetail = value;
            }
        }

        string name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public RelatedList()
        {
            Self = Implementation.Constructor();
        }
    }
}
