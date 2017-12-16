namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_ReportTypeMetadata.htm#apex_class_reports_reporttypemetadata
    /// </summary>
    public class ReportTypeMetadata
    {
        // infrastructure
        public ReportTypeMetadata(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportTypeMetadata));
            }
        }

        // API
        public ReportDivisionInfo getDivisionInfo()
        {
            return Self.getDivisionInfo();
        }

        public ReportScopeInfo getScopeInfo()
        {
            return Self.getScopeInfo();
        }

        public List<StandardDateFilterDurationGroup> getStandardDateFilterDurationGroups()
        {
            return Self.getStandardDateFilterDurationGroups();
        }

        public Map<string, StandardFilterInfo> getStandardFilterInfos()
        {
            return Self.getStandardFilterInfos();
        }

        public object clone()
        {
            return Self.clone();
        }

        public List<ReportTypeColumnCategory> getCategories()
        {
            return Self.getCategories();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
