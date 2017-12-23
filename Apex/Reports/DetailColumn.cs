namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_detailcolumn.htm#apex_class_reports_detailcolumn
    /// </summary>
    public class DetailColumn
    {
        // infrastructure
        public DetailColumn(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DetailColumn));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public ColumnDataType getDataType()
        {
            return Self.getDataType();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getName()
        {
            return Self.getName();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
