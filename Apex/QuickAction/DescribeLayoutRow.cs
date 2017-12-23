namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_quickaction_describelayoutrow.htm#apex_class_quickaction_describelayoutrow
    /// </summary>
    public class DescribeLayoutRow
    {
        // infrastructure
        public DescribeLayoutRow(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeLayoutRow));
            }
        }

        // API
        public List<DescribeLayoutItem> getLayoutItems()
        {
            return Self.getLayoutItems();
        }

        public int getNumItems()
        {
            return Self.getNumItems();
        }

        List<DescribeLayoutItem> layoutItems
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

        int numItems
        {
            get
            {
                return Self.numItems;
            }
            set
            {
                Self.numItems = value;
            }
        }
    }
}
