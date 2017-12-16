namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_groupinginfo.htm#apex_class_reports_groupinginfo
    /// </summary>
    public class GroupingInfo
    {
        // infrastructure
        public GroupingInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(GroupingInfo));
            }
        }

        // API
        public GroupingInfo()
        {
            Implementation.Constructor();
        }

        public GroupingInfo(string name, ColumnSortOrder sortOrder, DateGranularity dateGranularity, string sortAggregate)
        {
            Implementation.Constructor(name, sortOrder, dateGranularity, sortAggregate);
        }

        public object clone()
        {
            return Self.clone();
        }

        public DateGranularity getDateGranularity()
        {
            return Self.getDateGranularity();
        }

        public string getName()
        {
            return Self.getName();
        }

        public string getSortAggregate()
        {
            return Self.getSortAggregate();
        }

        public ColumnSortOrder getSortOrder()
        {
            return Self.getSortOrder();
        }

        public void setDateGranularity(DateGranularity dateGranularity)
        {
            Self.setDateGranularity(dateGranularity);
        }

        public void setDateGranularity(string value)
        {
            Self.setDateGranularity(value);
        }

        public void setName(string name)
        {
            Self.setName(name);
        }

        public void setSortAggregate(string sortAggregate)
        {
            Self.setSortAggregate(sortAggregate);
        }

        public void setSortOrder(ColumnSortOrder sortOrder)
        {
            Self.setSortOrder(sortOrder);
        }

        public void setSortOrder(string value)
        {
            Self.setSortOrder(value);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
