namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_TableSelection.htm#apex_class_DataSource_TableSelection
    /// </summary>
    public class TableSelection
    {
        // infrastructure
        public TableSelection(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TableSelection));
            }
        }

        // API
        List<ColumnSelection> columnsSelected
        {
            get
            {
                return Self.columnsSelected;
            }
            set
            {
                Self.columnsSelected = value;
            }
        }

        Filter filter
        {
            get
            {
                return Self.filter;
            }
            set
            {
                Self.filter = value;
            }
        }

        List<Order> order
        {
            get
            {
                return Self.order;
            }
            set
            {
                Self.order = value;
            }
        }

        string tableSelected
        {
            get
            {
                return Self.tableSelected;
            }
            set
            {
                Self.tableSelected = value;
            }
        }
    }
}
