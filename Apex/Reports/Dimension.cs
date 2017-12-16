namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_dimension.htm#apex_class_reports_dimension
    /// </summary>
    public class Dimension
    {
        // infrastructure
        public Dimension(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Dimension));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public List<GroupingValue> getGroupings()
        {
            return Self.getGroupings();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
