namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportresults.htm#apex_class_reports_reportresults
    /// </summary>
    public class ReportResults
    {
        // infrastructure
        public ReportResults(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportResults));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public bool getAllData()
        {
            return Self.getAllData();
        }

        public Map<string, ReportFact> getFactMap()
        {
            return Self.getFactMap();
        }

        public Dimension getGroupingsAcross()
        {
            return Self.getGroupingsAcross();
        }

        public Dimension getGroupingsDown()
        {
            return Self.getGroupingsDown();
        }

        public bool getHasDetailRows()
        {
            return Self.getHasDetailRows();
        }

        public ReportExtendedMetadata getReportExtendedMetadata()
        {
            return Self.getReportExtendedMetadata();
        }

        public ReportMetadata getReportMetadata()
        {
            return Self.getReportMetadata();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
