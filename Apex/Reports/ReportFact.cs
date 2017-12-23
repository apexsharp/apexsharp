namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportfact.htm#apex_class_reports_reportfact
    /// </summary>
    public class ReportFact
    {
        // infrastructure
        public ReportFact(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportFact));
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

        public string toString()
        {
            return Self.toString();
        }
    }
}
