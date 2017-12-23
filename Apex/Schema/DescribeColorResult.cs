namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_schema_describecolorresult.htm#apex_class_schema_describecolorresult
    /// </summary>
    public class DescribeColorResult
    {
        // infrastructure
        public DescribeColorResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeColorResult));
            }
        }

        // API
        public string getColor()
        {
            return Self.getColor();
        }

        public string getContext()
        {
            return Self.getContext();
        }

        public string getTheme()
        {
            return Self.getTheme();
        }

        string color
        {
            get
            {
                return Self.color;
            }
            set
            {
                Self.color = value;
            }
        }

        string context
        {
            get
            {
                return Self.context;
            }
            set
            {
                Self.context = value;
            }
        }

        string theme
        {
            get
            {
                return Self.theme;
            }
            set
            {
                Self.theme = value;
            }
        }
    }
}
