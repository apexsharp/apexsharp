namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportdescriberesult.htm#apex_class_reports_reportdescriberesult
    /// </summary>
    public class ReportDescribeResult
    {
        // infrastructure
        public ReportDescribeResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportDescribeResult));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public ReportExtendedMetadata getReportExtendedMetadata()
        {
            return Self.getReportExtendedMetadata();
        }

        public ReportMetadata getReportMetadata()
        {
            return Self.getReportMetadata();
        }

        public ReportTypeMetadata getReportTypeMetadata()
        {
            return Self.getReportTypeMetadata();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
