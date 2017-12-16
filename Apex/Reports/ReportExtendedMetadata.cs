namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportextendedmetadata.htm#apex_class_reports_reportextendedmetadata
    /// </summary>
    public class ReportExtendedMetadata
    {
        // infrastructure
        public ReportExtendedMetadata(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportExtendedMetadata));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public Map<string, AggregateColumn> getAggregateColumnInfo()
        {
            return Self.getAggregateColumnInfo();
        }

        public Map<string, DetailColumn> getDetailColumnInfo()
        {
            return Self.getDetailColumnInfo();
        }

        public Map<string, GroupingColumn> getGroupingColumnInfo()
        {
            return Self.getGroupingColumnInfo();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
