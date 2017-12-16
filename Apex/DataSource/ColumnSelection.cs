namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_ColumnSelection.htm#apex_class_DataSource_ColumnSelection
    /// </summary>
    public class ColumnSelection
    {
        // infrastructure
        public ColumnSelection(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ColumnSelection));
            }
        }

        // API
        QueryAggregation aggregation
        {
            get
            {
                return Self.aggregation;
            }
            set
            {
                Self.aggregation = value;
            }
        }

        string columnName
        {
            get
            {
                return Self.columnName;
            }
            set
            {
                Self.columnName = value;
            }
        }

        string tableName
        {
            get
            {
                return Self.tableName;
            }
            set
            {
                Self.tableName = value;
            }
        }
    }
}
