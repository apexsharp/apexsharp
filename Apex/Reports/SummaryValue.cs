namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_summaryvalue.htm#apex_class_reports_summaryvalue
    /// </summary>
    public class SummaryValue
    {
        // infrastructure
        public SummaryValue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SummaryValue));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public object getValue()
        {
            return Self.getValue();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
