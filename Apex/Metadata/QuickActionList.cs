namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_QuickActionList.htm#apex_class_Metadata_QuickActionList
    /// </summary>
    public class QuickActionList
    {
        // infrastructure
        public QuickActionList(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuickActionList));
            }
        }

        // API
        List<QuickActionListItem> quickActionListItems
        {
            get
            {
                return Self.quickActionListItems;
            }
            set
            {
                Self.quickActionListItems = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public QuickActionList()
        {
            Self = Implementation.Constructor();
        }
    }
}
