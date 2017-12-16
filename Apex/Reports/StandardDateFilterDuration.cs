namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_StandardDateFilterDuration.htm#apex_class_reports_StandardDateFilterDuration
    /// </summary>
    public class StandardDateFilterDuration
    {
        // infrastructure
        public StandardDateFilterDuration(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StandardDateFilterDuration));
            }
        }

        // API
        public string getEndDate()
        {
            return Self.getEndDate();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getStartDate()
        {
            return Self.getStartDate();
        }

        public string getValue()
        {
            return Self.getValue();
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
