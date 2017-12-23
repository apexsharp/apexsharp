namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_StandardDateFilterDurationGroup.htm#apex_class_reports_StandardDateFilterDurationGroup
    /// </summary>
    public class StandardDateFilterDurationGroup
    {
        // infrastructure
        public StandardDateFilterDurationGroup(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StandardDateFilterDurationGroup));
            }
        }

        // API
        public string getLabel()
        {
            return Self.getLabel();
        }

        public List<StandardDateFilterDuration> getStandardDateFilterDurations()
        {
            return Self.getStandardDateFilterDurations();
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
