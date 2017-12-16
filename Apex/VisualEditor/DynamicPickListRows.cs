namespace Apex.VisualEditor
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_VisualEditor_DynamicPickListRows.htm#apex_class_VisualEditor_DynamicPickListRows
    /// </summary>
    public class DynamicPickListRows
    {
        // infrastructure
        public DynamicPickListRows(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DynamicPickListRows));
            }
        }

        // API
        public DynamicPickListRows(List<DataRow> rows, bool containsAllRows)
        {
            Implementation.Constructor(rows, containsAllRows);
        }

        public DynamicPickListRows(List<DataRow> rows)
        {
            Implementation.Constructor(rows);
        }

        public DynamicPickListRows()
        {
            Implementation.Constructor();
        }

        public void addAllRows(List<DataRow> rows)
        {
            Self.addAllRows(rows);
        }

        public void addRow(DataRow row)
        {
            Self.addRow(row);
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool containsAllRows()
        {
            return Self.containsAllRows();
        }

        public DataRow get(int i)
        {
            return Self.get(i);
        }

        public List<DataRow> getDataRows()
        {
            return Self.getDataRows();
        }

        public void setContainsAllRows(bool containsAllRows)
        {
            Self.setContainsAllRows(containsAllRows);
        }

        public int size()
        {
            return Self.size();
        }

        public void sort()
        {
            Self.sort();
        }
    }
}
