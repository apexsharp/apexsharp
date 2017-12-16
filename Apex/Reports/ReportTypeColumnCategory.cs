namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reporttypecolumncategory.htm#apex_class_reports_reporttypecolumncategory
    /// </summary>
    public class ReportTypeColumnCategory
    {
        // infrastructure
        public ReportTypeColumnCategory(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportTypeColumnCategory));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public Map<string, ReportTypeColumn> getColumns()
        {
            return Self.getColumns();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
