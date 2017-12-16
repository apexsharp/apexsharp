namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_QuickActionListItem.htm#apex_class_Metadata_QuickActionListItem
    /// </summary>
    public class QuickActionListItem
    {
        // infrastructure
        public QuickActionListItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuickActionListItem));
            }
        }

        // API
        string quickActionName
        {
            get
            {
                return Self.quickActionName;
            }
            set
            {
                Self.quickActionName = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public QuickActionListItem()
        {
            Implementation.Constructor();
        }
    }
}
