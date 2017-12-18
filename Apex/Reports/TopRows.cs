namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_TopRows.htm#apex_class_reports_TopRows
    /// </summary>
    public class TopRows
    {
        // infrastructure
        public TopRows(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TopRows));
            }
        }

        // API
        public TopRows(int rowLimit, ColumnSortOrder direction)
        {
            Self = Implementation.Constructor(rowLimit, direction);
        }

        public TopRows()
        {
            Self = Implementation.Constructor();
        }

        public ColumnSortOrder getDirection()
        {
            return Self.getDirection();
        }

        public int getRowLimit()
        {
            return Self.getRowLimit();
        }

        public void setDirection(string value)
        {
            Self.setDirection(value);
        }

        public void setDirection(ColumnSortOrder direction)
        {
            Self.setDirection(direction);
        }

        public void setRowLimit(int rowLimit)
        {
            Self.setRowLimit(rowLimit);
        }

        public string toString()
        {
            return Self.toString();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
