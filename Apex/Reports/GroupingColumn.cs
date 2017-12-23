namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_groupingcolumn.htm#apex_class_reports_groupingcolumn
    /// </summary>
    public class GroupingColumn
    {
        // infrastructure
        public GroupingColumn(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(GroupingColumn));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public ColumnDataType getDataType()
        {
            return Self.getDataType();
        }

        public int getGroupingLevel()
        {
            return Self.getGroupingLevel();
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
