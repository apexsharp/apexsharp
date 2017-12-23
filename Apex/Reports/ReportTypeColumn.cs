namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reporttypecolumn.htm#apex_class_reports_reporttypecolumn
    /// </summary>
    public class ReportTypeColumn
    {
        // infrastructure
        public ReportTypeColumn(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportTypeColumn));
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

        public bool getFilterable()
        {
            return Self.getFilterable();
        }

        public List<FilterValue> getFilterValues()
        {
            return Self.getFilterValues();
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
