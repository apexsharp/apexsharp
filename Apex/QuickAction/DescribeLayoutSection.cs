namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_quickaction_describelayoutsection.htm#apex_class_quickaction_describelayoutsection
    /// </summary>
    public class DescribeLayoutSection
    {
        // infrastructure
        public DescribeLayoutSection(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeLayoutSection));
            }
        }

        // API
        bool collapsed
        {
            get
            {
                return Self.collapsed;
            }
            set
            {
                Self.collapsed = value;
            }
        }

        ID layoutsectionid
        {
            get
            {
                return Self.layoutsectionid;
            }
            set
            {
                Self.layoutsectionid = value;
            }
        }

        public int getColumns()
        {
            return Self.getColumns();
        }

        public string getHeading()
        {
            return Self.getHeading();
        }

        public List<DescribeLayoutRow> getLayoutRows()
        {
            return Self.getLayoutRows();
        }

        public ID getLayoutSectionId()
        {
            return Self.getLayoutSectionId();
        }

        public ID getParentLayoutId()
        {
            return Self.getParentLayoutId();
        }

        public int getRows()
        {
            return Self.getRows();
        }

        public bool isCollapsed()
        {
            return Self.isCollapsed();
        }

        public bool isUseCollapsibleSection()
        {
            return Self.isUseCollapsibleSection();
        }

        public bool isUseHeading()
        {
            return Self.isUseHeading();
        }

        int columns
        {
            get
            {
                return Self.columns;
            }
            set
            {
                Self.columns = value;
            }
        }

        string heading
        {
            get
            {
                return Self.heading;
            }
            set
            {
                Self.heading = value;
            }
        }

        List<DescribeLayoutRow> layoutRows
        {
            get
            {
                return Self.layoutRows;
            }
            set
            {
                Self.layoutRows = value;
            }
        }

        ID layoutSectionId
        {
            get
            {
                return Self.layoutSectionId;
            }
            set
            {
                Self.layoutSectionId = value;
            }
        }

        ID parentLayoutId
        {
            get
            {
                return Self.parentLayoutId;
            }
            set
            {
                Self.parentLayoutId = value;
            }
        }

        int rows
        {
            get
            {
                return Self.rows;
            }
            set
            {
                Self.rows = value;
            }
        }

        string tabOrder
        {
            get
            {
                return Self.tabOrder;
            }
            set
            {
                Self.tabOrder = value;
            }
        }

        bool useCollapsibleSection
        {
            get
            {
                return Self.useCollapsibleSection;
            }
            set
            {
                Self.useCollapsibleSection = value;
            }
        }

        bool useHeading
        {
            get
            {
                return Self.useHeading;
            }
            set
            {
                Self.useHeading = value;
            }
        }

        public string getTabOrder()
        {
            return Self.getTabOrder();
        }
    }
}
