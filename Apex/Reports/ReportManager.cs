namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportmanager.htm#apex_class_reports_reportmanager
    /// </summary>
    public class ReportManager
    {
        // infrastructure
        public ReportManager(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportManager));
            }
        }

        // API
        public ReportManager()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static ReportDescribeResult describeReport(ID reportId)
        {
            return Implementation.describeReport(reportId);
        }

        public static Map<string, List<FilterOperator>> getDatatypeFilterOperatorMap()
        {
            return Implementation.getDatatypeFilterOperatorMap();
        }

        public static ReportInstance getReportInstance(ID instanceId)
        {
            return Implementation.getReportInstance(instanceId);
        }

        public static List<ReportInstance> getReportInstances(ID reportId)
        {
            return Implementation.getReportInstances(reportId);
        }

        public static ReportInstance runAsyncReport(ID reportId, bool includeDetails)
        {
            return Implementation.runAsyncReport(reportId, includeDetails);
        }

        public static ReportInstance runAsyncReport(ID reportId)
        {
            return Implementation.runAsyncReport(reportId);
        }

        public static ReportInstance runAsyncReport(ID reportId, ReportMetadata rmData, bool includeDetails)
        {
            return Implementation.runAsyncReport(reportId, rmData, includeDetails);
        }

        public static ReportInstance runAsyncReport(ID reportId, ReportMetadata rmData)
        {
            return Implementation.runAsyncReport(reportId, rmData);
        }

        public static ReportResults runReport(ID reportId, bool includeDetails)
        {
            return Implementation.runReport(reportId, includeDetails);
        }

        public static ReportResults runReport(ID reportId, ReportMetadata rmData, bool includeDetails)
        {
            return Implementation.runReport(reportId, rmData, includeDetails);
        }

        public static ReportResults runReport(ID reportId, ReportMetadata rmData)
        {
            return Implementation.runReport(reportId, rmData);
        }

        public static ReportResults runReport(ID reportId)
        {
            return Implementation.runReport(reportId);
        }
    }
}
