namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_groupingvalue.htm#apex_class_reports_groupingvalue
    /// </summary>
    public class GroupingValue
    {
        // infrastructure
        public GroupingValue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(GroupingValue));
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

        public string getKey()
        {
            return Self.getKey();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public object getValue()
        {
            return Self.getValue();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
