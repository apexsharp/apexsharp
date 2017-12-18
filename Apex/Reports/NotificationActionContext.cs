namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_NotificationActionContext.htm#apex_class_reports_NotificationActionContext
    /// </summary>
    public class NotificationActionContext
    {
        // infrastructure
        public NotificationActionContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NotificationActionContext));
            }
        }

        // API
        public NotificationActionContext(ReportInstance reportInstance, ThresholdInformation thresholdInformation)
        {
            Self = Implementation.Constructor(reportInstance, thresholdInformation);
        }

        public ReportInstance getReportInstance()
        {
            return Self.getReportInstance();
        }

        public ThresholdInformation getThresholdInformation()
        {
            return Self.getThresholdInformation();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
