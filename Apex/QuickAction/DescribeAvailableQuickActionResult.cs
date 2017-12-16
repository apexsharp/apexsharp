namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_quickaction_describeavailablequickactionresult.htm#apex_class_quickaction_describeavailablequickactionresult
    /// </summary>
    public class DescribeAvailableQuickActionResult
    {
        // infrastructure
        public DescribeAvailableQuickActionResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeAvailableQuickActionResult));
            }
        }

        // API
        public string getActionEnumOrId()
        {
            return Self.getActionEnumOrId();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getName()
        {
            return Self.getName();
        }

        public string getType()
        {
            return Self.getType();
        }

        string actionEnumOrId
        {
            get
            {
                return Self.actionEnumOrId;
            }
            set
            {
                Self.actionEnumOrId = value;
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

        string name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
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
    }
}
