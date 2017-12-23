namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportdatacell.htm#apex_class_reports_reportdatacell
    /// </summary>
    public class ReportDataCell
    {
        // infrastructure
        public ReportDataCell(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportDataCell));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public object getValue()
        {
            return Self.getValue();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
