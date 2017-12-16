namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reportmetadata.htm#apex_class_reports_reportmetadata
    /// </summary>
    public class ReportMetadata
    {
        // infrastructure
        public ReportMetadata(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportMetadata));
            }
        }

        // API
        public List<BucketField> getBuckets()
        {
            return Self.getBuckets();
        }

        public CrossFilter getCrossFilters()
        {
            return Self.getCrossFilters();
        }

        public Map<string, ReportCsf> getCustomSummaryFormula()
        {
            return Self.getCustomSummaryFormula();
        }

        public string getDescription()
        {
            return Self.getDescription();
        }

        public string getDivision()
        {
            return Self.getDivision();
        }

        public bool getHasDetailRows()
        {
            return Self.getHasDetailRows();
        }

        public bool getHasRecordCount()
        {
            return Self.getHasRecordCount();
        }

        public string getScope()
        {
            return Self.getScope();
        }

        public bool getShowGrandTotal()
        {
            return Self.getShowGrandTotal();
        }

        public bool getShowSubtotals()
        {
            return Self.getShowSubtotals();
        }

        public List<SortColumn> getSortBy()
        {
            return Self.getSortBy();
        }

        public StandardDateFilter getStandardDateFilter()
        {
            return Self.getStandardDateFilter();
        }

        public List<StandardFilter> getStandardFilters()
        {
            return Self.getStandardFilters();
        }

        public TopRows getTopRows()
        {
            return Self.getTopRows();
        }

        public void setAggregates(List<string> aggregates)
        {
            Self.setAggregates(aggregates);
        }

        public void setBuckets(List<BucketField> buckets)
        {
            Self.setBuckets(buckets);
        }

        public void setCrossFilters(List<CrossFilter> crossFilters)
        {
            Self.setCrossFilters(crossFilters);
        }

        public void setCurrencyCode(string currencyCode)
        {
            Self.setCurrencyCode(currencyCode);
        }

        public void setCustomSummaryFormula(Map<string, ReportCsf> customSummaryFormula)
        {
            Self.setCustomSummaryFormula(customSummaryFormula);
        }

        public void setDescription(string description)
        {
            Self.setDescription(description);
        }

        public void setDetailColumns(List<string> detailColumns)
        {
            Self.setDetailColumns(detailColumns);
        }

        public void setDeveloperName(string developerName)
        {
            Self.setDeveloperName(developerName);
        }

        public void setDivision(string division)
        {
            Self.setDivision(division);
        }

        public void setGroupingsAcross(List<GroupingInfo> groupingInfo)
        {
            Self.setGroupingsAcross(groupingInfo);
        }

        public void setGroupingsDown(List<GroupingInfo> groupingInfo)
        {
            Self.setGroupingsDown(groupingInfo);
        }

        public void setHasDetailRows(bool hasDetailRows)
        {
            Self.setHasDetailRows(hasDetailRows);
        }

        public void setHasRecordCount(bool hasRecordCount)
        {
            Self.setHasRecordCount(hasRecordCount);
        }

        public void setId(ID id)
        {
            Self.setId(id);
        }

        public void setName(string name)
        {
            Self.setName(name);
        }

        public void setReportFormat(ReportFormat format)
        {
            Self.setReportFormat(format);
        }

        public void setReportType(ReportType reportType)
        {
            Self.setReportType(reportType);
        }

        public void setScope(string scopeName)
        {
            Self.setScope(scopeName);
        }

        public void setShowGrandTotal(bool showGrandTotal)
        {
            Self.setShowGrandTotal(showGrandTotal);
        }

        public void setShowSubtotals(bool showSubtotals)
        {
            Self.setShowSubtotals(showSubtotals);
        }

        public void setSortBy(List<SortColumn> column)
        {
            Self.setSortBy(column);
        }

        public void setStandardDateFilter(StandardDateFilter dateFilter)
        {
            Self.setStandardDateFilter(dateFilter);
        }

        public void setStandardFilters(List<StandardFilter> filters)
        {
            Self.setStandardFilters(filters);
        }

        public TopRows setTopRows(TopRows topRows)
        {
            return Self.setTopRows(topRows);
        }

        public ReportMetadata()
        {
            Implementation.Constructor();
        }

        public ReportMetadata(string name, string developerName, ID id, List<GroupingInfo> groupingsAcross, List<GroupingInfo> groupingsDown, List<string> aggregates, List<BucketField> buckets, List<string> detailColumns, string reportBooleanFilter, List<ReportFilter> reportFilters, List<string> historicalSnapshotDates, ReportFormat reportFormat, ReportType reportType, string currencyCode, string scope, string division, List<SortColumn> sortBy, StandardDateFilter standardDateFilter, bool hasDetailRows, bool hasRecordCount, List<StandardFilter> standardFilters, string description, bool showSubtotals, bool showGrandTotal, TopRows topRows, Map<string, ReportCsf> customSummaryFormula, List<CrossFilter> crossFilters)
        {
            Implementation.Constructor(name, developerName, id, groupingsAcross, groupingsDown, aggregates, buckets, detailColumns, reportBooleanFilter, reportFilters, historicalSnapshotDates, reportFormat, reportType, currencyCode, scope, division, sortBy, standardDateFilter, hasDetailRows, hasRecordCount, standardFilters, description, showSubtotals, showGrandTotal, topRows, customSummaryFormula, crossFilters);
        }

        public object clone()
        {
            return Self.clone();
        }

        public List<string> getAggregates()
        {
            return Self.getAggregates();
        }

        public string getCurrencyCode()
        {
            return Self.getCurrencyCode();
        }

        public List<string> getDetailColumns()
        {
            return Self.getDetailColumns();
        }

        public string getDeveloperName()
        {
            return Self.getDeveloperName();
        }

        public List<GroupingInfo> getGroupingsAcross()
        {
            return Self.getGroupingsAcross();
        }

        public List<GroupingInfo> getGroupingsDown()
        {
            return Self.getGroupingsDown();
        }

        public List<string> getHistoricalSnapshotDates()
        {
            return Self.getHistoricalSnapshotDates();
        }

        public ID getId()
        {
            return Self.getId();
        }

        public string getName()
        {
            return Self.getName();
        }

        public string getReportBooleanFilter()
        {
            return Self.getReportBooleanFilter();
        }

        public List<ReportFilter> getReportFilters()
        {
            return Self.getReportFilters();
        }

        public ReportFormat getReportFormat()
        {
            return Self.getReportFormat();
        }

        public ReportType getReportType()
        {
            return Self.getReportType();
        }

        public void setHistoricalSnapshotDates(List<string> historicalSnapshotDates)
        {
            Self.setHistoricalSnapshotDates(historicalSnapshotDates);
        }

        public void setReportBooleanFilter(string reportBooleanFilter)
        {
            Self.setReportBooleanFilter(reportBooleanFilter);
        }

        public void setReportFilters(List<ReportFilter> reportFilters)
        {
            Self.setReportFilters(reportFilters);
        }

        public void setReportFormat(string value)
        {
            Self.setReportFormat(value);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
