namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_ReportDivisionInfo.htm#apex_class_reports_ReportDivisionInfo
    /// </summary>
    public class ReportDivisionInfo
    {
        // infrastructure
        public ReportDivisionInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportDivisionInfo));
            }
        }

        // API
        public string getDefaultValue()
        {
            return Self.getDefaultValue();
        }

        public List<FilterValue> getValues()
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
