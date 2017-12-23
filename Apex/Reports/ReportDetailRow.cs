namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportdetailrow.htm#apex_class_reports_reportdetailrow
    /// </summary>
    public class ReportDetailRow
    {
        // infrastructure
        public ReportDetailRow(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportDetailRow));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public List<ReportDataCell> getDataCells()
        {
            return Self.getDataCells();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
