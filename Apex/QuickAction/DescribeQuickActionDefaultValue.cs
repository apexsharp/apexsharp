namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_quickaction_describequickactiondefaultvalue.htm#apex_class_quickaction_describequickactiondefaultvalue
    /// </summary>
    public class DescribeQuickActionDefaultValue
    {
        // infrastructure
        public DescribeQuickActionDefaultValue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeQuickActionDefaultValue));
            }
        }

        // API
        public string getDefaultValue()
        {
            return Self.getDefaultValue();
        }

        public string getField()
        {
            return Self.getField();
        }

        string defaultValue
        {
            get
            {
                return Self.defaultValue;
            }
            set
            {
                Self.defaultValue = value;
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
    }
}
