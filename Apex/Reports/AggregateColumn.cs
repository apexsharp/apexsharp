namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_aggregatecolumn.htm#apex_class_reports_aggregatecolumn
    /// </summary>
    public class AggregateColumn
    {
        // infrastructure
        public AggregateColumn(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AggregateColumn));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getAcrossGroupingContext()
        {
            return Self.getAcrossGroupingContext();
        }

        public ColumnDataType getDataType()
        {
            return Self.getDataType();
        }

        public string getDownGroupingContext()
        {
            return Self.getDownGroupingContext();
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
