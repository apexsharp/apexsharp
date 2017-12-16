namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportinstance.htm#apex_class_reports_reportinstance
    /// </summary>
    public class ReportInstance
    {
        // infrastructure
        public ReportInstance(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportInstance));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public Datetime getCompletionDate()
        {
            return Self.getCompletionDate();
        }

        public ID getId()
        {
            return Self.getId();
        }

        public ID getOwnerId()
        {
            return Self.getOwnerId();
        }

        public ID getReportId()
        {
            return Self.getReportId();
        }

        public ReportResults getReportResults()
        {
            return Self.getReportResults();
        }

        public Datetime getRequestDate()
        {
            return Self.getRequestDate();
        }

        public string getStatus()
        {
            return Self.getStatus();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
