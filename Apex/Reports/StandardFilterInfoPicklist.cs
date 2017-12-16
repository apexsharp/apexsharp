namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_StandardFilterInfoPicklist.htm#apex_class_reports_StandardFilterInfoPicklist
    /// </summary>
    public class StandardFilterInfoPicklist
    {
        // infrastructure
        public StandardFilterInfoPicklist(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StandardFilterInfoPicklist));
            }
        }

        // API
        public string getDefaultValue()
        {
            return Self.getDefaultValue();
        }

        public List<FilterValue> getFilterValues()
        {
            return Self.getFilterValues();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public StandardFilterType getType()
        {
            return Self.getType();
        }

        public object clone()
        {
            return Self.clone();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
