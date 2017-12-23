namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_SummaryLayoutItem.htm#apex_class_Metadata_SummaryLayoutItem
    /// </summary>
    public class SummaryLayoutItem
    {
        // infrastructure
        public SummaryLayoutItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SummaryLayoutItem));
            }
        }

        // API
        string customLink
        {
            get
            {
                return Self.customLink;
            }
            set
            {
                Self.customLink = value;
            }
        }

        string field
        {
            get
            {
                return Self.field;
            }
            set
            {
                Self.field = value;
            }
        }

        int posX
        {
            get
            {
                return Self.posX;
            }
            set
            {
                Self.posX = value;
            }
        }

        int posY
        {
            get
            {
                return Self.posY;
            }
            set
            {
                Self.posY = value;
            }
        }

        int posZ
        {
            get
            {
                return Self.posZ;
            }
            set
            {
                Self.posZ = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public SummaryLayoutItem()
        {
            Self = Implementation.Constructor();
        }
    }
}
