namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_ReportChartComponentLayoutItem.htm#apex_class_Metadata_ReportChartComponentLayoutItem
    /// </summary>
    public class ReportChartComponentLayoutItem
    {
        // infrastructure
        public ReportChartComponentLayoutItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportChartComponentLayoutItem));
            }
        }

        // API
        bool cacheData
        {
            get
            {
                return Self.cacheData;
            }
            set
            {
                Self.cacheData = value;
            }
        }

        string contextFilterableField
        {
            get
            {
                return Self.contextFilterableField;
            }
            set
            {
                Self.contextFilterableField = value;
            }
        }

        string error
        {
            get
            {
                return Self.error;
            }
            set
            {
                Self.error = value;
            }
        }

        bool hideOnError
        {
            get
            {
                return Self.hideOnError;
            }
            set
            {
                Self.hideOnError = value;
            }
        }

        bool includeContext
        {
            get
            {
                return Self.includeContext;
            }
            set
            {
                Self.includeContext = value;
            }
        }

        string reportName
        {
            get
            {
                return Self.reportName;
            }
            set
            {
                Self.reportName = value;
            }
        }

        bool showTitle
        {
            get
            {
                return Self.showTitle;
            }
            set
            {
                Self.showTitle = value;
            }
        }

        ReportChartComponentSize size
        {
            get
            {
                return Self.size;
            }
            set
            {
                Self.size = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public ReportChartComponentLayoutItem()
        {
            Self = Implementation.Constructor();
        }
    }
}
