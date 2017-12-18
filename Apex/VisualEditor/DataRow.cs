namespace Apex.VisualEditor
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_VisualEditor_DataRow.htm#apex_class_VisualEditor_DataRow
    /// </summary>
    public class DataRow
    {
        // infrastructure
        public DataRow(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DataRow));
            }
        }

        // API
        public DataRow(string label, object value, bool selected)
        {
            Self = Implementation.Constructor(label, value, selected);
        }

        public DataRow(string label, object value)
        {
            Self = Implementation.Constructor(label, value);
        }

        public object clone()
        {
            return Self.clone();
        }

        public int compareTo(DataRow o)
        {
            return Self.compareTo(o);
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public object getValue()
        {
            return Self.getValue();
        }

        public bool isSelected()
        {
            return Self.isSelected();
        }
    }
}
