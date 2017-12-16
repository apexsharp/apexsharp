namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportfactwithdetails.htm#apex_class_reports_reportfactwithdetails
    /// </summary>
    public class ReportFactWithDetails
    {
        // infrastructure
        public ReportFactWithDetails(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportFactWithDetails));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public List<SummaryValue> getAggregates()
        {
            return Self.getAggregates();
        }

        public string getKey()
        {
            return Self.getKey();
        }

        public List<ReportDetailRow> getRows()
        {
            return Self.getRows();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
