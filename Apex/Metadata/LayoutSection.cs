namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_LayoutSection.htm#apex_class_Metadata_LayoutSection
    /// </summary>
    public class LayoutSection
    {
        // infrastructure
        public LayoutSection(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LayoutSection));
            }
        }

        // API
        bool customLabel
        {
            get
            {
                return Self.customLabel;
            }
            set
            {
                Self.customLabel = value;
            }
        }

        bool detailHeading
        {
            get
            {
                return Self.detailHeading;
            }
            set
            {
                Self.detailHeading = value;
            }
        }

        bool editHeading
        {
            get
            {
                return Self.editHeading;
            }
            set
            {
                Self.editHeading = value;
            }
        }

        string label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        List<LayoutColumn> layoutColumns
        {
            get
            {
                return Self.layoutColumns;
            }
            set
            {
                Self.layoutColumns = value;
            }
        }

        LayoutSectionStyle style
        {
            get
            {
                return Self.style;
            }
            set
            {
                Self.style = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public LayoutSection()
        {
            Implementation.Constructor();
        }
    }
}
