namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_StandardFilterInfo.htm#apex_class_reports_StandardFilterInfo
    /// </summary>
    public class StandardFilterInfo
    {
        // infrastructure
        public StandardFilterInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StandardFilterInfo));
            }
        }

        // API
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
