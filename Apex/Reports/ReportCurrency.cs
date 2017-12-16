namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportcurrency.htm#apex_class_reports_reportcurrency
    /// </summary>
    public class ReportCurrency
    {
        // infrastructure
        public ReportCurrency(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportCurrency));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public decimal getAmount()
        {
            return Self.getAmount();
        }

        public string getCurrencyCode()
        {
            return Self.getCurrencyCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
