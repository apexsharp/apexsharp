namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_SortColumn.htm#apex_class_reports_SortColumn
    /// </summary>
    public class SortColumn
    {
        // infrastructure
        public SortColumn(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SortColumn));
            }
        }

        // API
        public string getSortColumn()
        {
            return Self.getSortColumn();
        }

        public ColumnSortOrder getSortOrder()
        {
            return Self.getSortOrder();
        }

        public void setSortColumn(string sortColumn)
        {
            Self.setSortColumn(sortColumn);
        }

        public void setSortOrder(ColumnSortOrder sortOrder)
        {
            Self.setSortOrder(sortOrder);
        }

        public SortColumn()
        {
            Self = Implementation.Constructor();
        }

        public SortColumn(string sortColumn, ColumnSortOrder sortOrder)
        {
            Self = Implementation.Constructor(sortColumn, sortOrder);
        }

        public object clone()
        {
            return Self.clone();
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
