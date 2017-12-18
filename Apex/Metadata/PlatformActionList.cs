namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_PlatformActionList.htm#apex_class_Metadata_PlatformActionList
    /// </summary>
    public class PlatformActionList
    {
        // infrastructure
        public PlatformActionList(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PlatformActionList));
            }
        }

        // API
        PlatformActionListContextEnum actionListContext
        {
            get
            {
                return Self.actionListContext;
            }
            set
            {
                Self.actionListContext = value;
            }
        }

        List<PlatformActionListItem> platformActionListItems
        {
            get
            {
                return Self.platformActionListItems;
            }
            set
            {
                Self.platformActionListItems = value;
            }
        }

        string relatedSourceEntity
        {
            get
            {
                return Self.relatedSourceEntity;
            }
            set
            {
                Self.relatedSourceEntity = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public PlatformActionList()
        {
            Self = Implementation.Constructor();
        }
    }
}
