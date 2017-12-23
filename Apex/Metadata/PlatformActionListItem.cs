namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_PlatformActionListItem.htm#apex_class_Metadata_PlatformActionListItem
    /// </summary>
    public class PlatformActionListItem
    {
        // infrastructure
        public PlatformActionListItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PlatformActionListItem));
            }
        }

        // API
        string actionName
        {
            get
            {
                return Self.actionName;
            }
            set
            {
                Self.actionName = value;
            }
        }

        PlatformActionTypeEnum actionType
        {
            get
            {
                return Self.actionType;
            }
            set
            {
                Self.actionType = value;
            }
        }

        int sortOrder
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

        string subtype
        {
            get
            {
                return Self.subtype;
            }
            set
            {
                Self.subtype = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public PlatformActionListItem()
        {
            Self = Implementation.Constructor();
        }
    }
}
