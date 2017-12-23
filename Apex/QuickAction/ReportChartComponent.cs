namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ReportChartComponent
    {
        // infrastructure
        public ReportChartComponent(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportChartComponent));
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

        string size
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

        public bool getCacheData()
        {
            return Self.getCacheData();
        }

        public string getContextFilterableField()
        {
            return Self.getContextFilterableField();
        }

        public int getDisplayLines()
        {
            return Self.getDisplayLines();
        }

        public string getError()
        {
            return Self.getError();
        }

        public bool getHideOnError()
        {
            return Self.getHideOnError();
        }

        public bool getIncludeContext()
        {
            return Self.getIncludeContext();
        }

        public bool getShowTitle()
        {
            return Self.getShowTitle();
        }

        public string getSize()
        {
            return Self.getSize();
        }

        public int getTabOrder()
        {
            return Self.getTabOrder();
        }

        public string getType()
        {
            return Self.getType();
        }

        public string getValue()
        {
            return Self.getValue();
        }
    }
}
