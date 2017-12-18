namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_SummaryLayout.htm#apex_class_Metadata_SummaryLayout
    /// </summary>
    public class SummaryLayout
    {
        // infrastructure
        public SummaryLayout(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SummaryLayout));
            }
        }

        // API
        string masterLabel
        {
            get
            {
                return Self.masterLabel;
            }
            set
            {
                Self.masterLabel = value;
            }
        }

        int sizeX
        {
            get
            {
                return Self.sizeX;
            }
            set
            {
                Self.sizeX = value;
            }
        }

        int sizeY
        {
            get
            {
                return Self.sizeY;
            }
            set
            {
                Self.sizeY = value;
            }
        }

        int sizeZ
        {
            get
            {
                return Self.sizeZ;
            }
            set
            {
                Self.sizeZ = value;
            }
        }

        List<SummaryLayoutItem> summaryLayoutItems
        {
            get
            {
                return Self.summaryLayoutItems;
            }
            set
            {
                Self.summaryLayoutItems = value;
            }
        }

        SummaryLayoutStyleEnum summaryLayoutStyle
        {
            get
            {
                return Self.summaryLayoutStyle;
            }
            set
            {
                Self.summaryLayoutStyle = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public SummaryLayout()
        {
            Self = Implementation.Constructor();
        }
    }
}
