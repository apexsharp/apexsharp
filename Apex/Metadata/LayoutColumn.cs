namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_LayoutColumn.htm#apex_class_Metadata_LayoutColumn
    /// </summary>
    public class LayoutColumn
    {
        // infrastructure
        public LayoutColumn(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LayoutColumn));
            }
        }

        // API
        List<LayoutItem> layoutItems
        {
            get
            {
                return Self.layoutItems;
            }
            set
            {
                Self.layoutItems = value;
            }
        }

        string reserved
        {
            get
            {
                return Self.reserved;
            }
            set
            {
                Self.reserved = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public LayoutColumn()
        {
            Self = Implementation.Constructor();
        }
    }
}
