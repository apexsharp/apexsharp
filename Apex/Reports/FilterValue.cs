namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_filtervalue.htm#apex_class_reports_filtervalue
    /// </summary>
    public class FilterValue
    {
        // infrastructure
        public FilterValue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FilterValue));
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

        public string getName()
        {
            return Self.getName();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
