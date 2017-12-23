namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportfilter.htm#apex_class_reports_reportfilter
    /// </summary>
    public class ReportFilter
    {
        // infrastructure
        public ReportFilter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportFilter));
            }
        }

        // API
        public ReportFilter()
        {
            Self = Implementation.Constructor();
        }

        public ReportFilter(string column, string @operator, string value)
        {
            Self = Implementation.Constructor(column, @operator, value);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getColumn()
        {
            return Self.getColumn();
        }

        public string getOperator()
        {
            return Self.getOperator();
        }

        public string getValue()
        {
            return Self.getValue();
        }

        public void setColumn(string column)
        {
            Self.setColumn(column);
        }

        public void setOperator(string @operator)
        {
            Self.setOperator(@operator);
        }

        public void setValue(string value)
        {
            Self.setValue(value);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
