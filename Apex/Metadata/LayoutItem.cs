namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_LayoutItem.htm#apex_class_Metadata_LayoutItem
    /// </summary>
    public class LayoutItem
    {
        // infrastructure
        public LayoutItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LayoutItem));
            }
        }

        // API
        AnalyticsCloudComponentLayoutItem analyticsCloudComponent
        {
            get
            {
                return Self.analyticsCloudComponent;
            }
            set
            {
                Self.analyticsCloudComponent = value;
            }
        }

        UiBehavior behavior
        {
            get
            {
                return Self.behavior;
            }
            set
            {
                Self.behavior = value;
            }
        }

        string canvas
        {
            get
            {
                return Self.canvas;
            }
            set
            {
                Self.canvas = value;
            }
        }

        string component
        {
            get
            {
                return Self.component;
            }
            set
            {
                Self.component = value;
            }
        }

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

        bool emptySpace
        {
            get
            {
                return Self.emptySpace;
            }
            set
            {
                Self.emptySpace = value;
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

        int height
        {
            get
            {
                return Self.height;
            }
            set
            {
                Self.height = value;
            }
        }

        string page_x
        {
            get
            {
                return Self.page_x;
            }
            set
            {
                Self.page_x = value;
            }
        }

        ReportChartComponentLayoutItem reportChartComponent
        {
            get
            {
                return Self.reportChartComponent;
            }
            set
            {
                Self.reportChartComponent = value;
            }
        }

        string scontrol
        {
            get
            {
                return Self.scontrol;
            }
            set
            {
                Self.scontrol = value;
            }
        }

        bool showLabel
        {
            get
            {
                return Self.showLabel;
            }
            set
            {
                Self.showLabel = value;
            }
        }

        bool showScrollbars
        {
            get
            {
                return Self.showScrollbars;
            }
            set
            {
                Self.showScrollbars = value;
            }
        }

        string width
        {
            get
            {
                return Self.width;
            }
            set
            {
                Self.width = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public LayoutItem()
        {
            Implementation.Constructor();
        }
    }
}
