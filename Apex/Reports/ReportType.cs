namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_reporttype.htm#apex_class_reports_reporttype
    /// </summary>
    public class ReportType
    {
        // infrastructure
        public ReportType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportType));
            }
        }

        // API
        public ReportType()
        {
            Self = Implementation.Constructor();
        }

        public ReportType(string type, string label)
        {
            Self = Implementation.Constructor(type, label);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getType()
        {
            return Self.getType();
        }

        public void setLabel(string label)
        {
            Self.setLabel(label);
        }

        public void setType(string type)
        {
            Self.setType(type);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
