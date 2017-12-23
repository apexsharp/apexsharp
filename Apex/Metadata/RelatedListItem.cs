namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_RelatedListItem.htm#apex_class_Metadata_RelatedListItem
    /// </summary>
    public class RelatedListItem
    {
        // infrastructure
        public RelatedListItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RelatedListItem));
            }
        }

        // API
        List<string> customButtons
        {
            get
            {
                return Self.customButtons;
            }
            set
            {
                Self.customButtons = value;
            }
        }

        List<string> excludeButtons
        {
            get
            {
                return Self.excludeButtons;
            }
            set
            {
                Self.excludeButtons = value;
            }
        }

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

        string relatedList
        {
            get
            {
                return Self.relatedList;
            }
            set
            {
                Self.relatedList = value;
            }
        }

        string sortField
        {
            get
            {
                return Self.sortField;
            }
            set
            {
                Self.sortField = value;
            }
        }

        SortOrder sortOrder
        {
            get
            {
                return Self.sortOrder;
            }
            set
            {
                Self.sortOrder = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public RelatedListItem()
        {
            Self = Implementation.Constructor();
        }
    }
}
