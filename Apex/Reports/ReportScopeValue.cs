namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_ReportScopeValue.htm#apex_class_reports_ReportScopeValue
    /// </summary>
    public class ReportScopeValue
    {
        // infrastructure
        public ReportScopeValue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportScopeValue));
            }
        }

        // API
        public bool getAllowsDivision()
        {
            return Self.getAllowsDivision();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getValue()
        {
            return Self.getValue();
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
