namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_ReportScopeInfo.htm#apex_class_reports_ReportScopeInfo
    /// </summary>
    public class ReportScopeInfo
    {
        // infrastructure
        public ReportScopeInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportScopeInfo));
            }
        }

        // API
        public string getDefaultValue()
        {
            return Self.getDefaultValue();
        }

        public List<ReportScopeValue> getValues()
        {
            return Self.getValues();
        }

        public object clone()
        {
            return Self.clone();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
