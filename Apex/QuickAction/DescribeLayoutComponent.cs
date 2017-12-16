namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_quickaction_describelayoutcomponent.htm#apex_class_quickaction_describelayoutcomponent
    /// </summary>
    public class DescribeLayoutComponent
    {
        // infrastructure
        public DescribeLayoutComponent(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeLayoutComponent));
            }
        }

        // API
        public int getDisplayLines()
        {
            return Self.getDisplayLines();
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

        int displayLines
        {
            get
            {
                return Self.displayLines;
            }
            set
            {
                Self.displayLines = value;
            }
        }

        int tabOrder
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

        string type
        {
            get
            {
                return Self.type;
            }
            set
            {
                Self.type = value;
            }
        }

        string value
        {
            get
            {
                return Self.value;
            }
            set
            {
                Self.value = value;
            }
        }
    }
}
