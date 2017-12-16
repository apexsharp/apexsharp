namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_StandardFilter.htm#apex_class_reports_StandardFilter
    /// </summary>
    public class StandardFilter
    {
        // infrastructure
        public StandardFilter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StandardFilter));
            }
        }

        // API
        public string getName()
        {
            return Self.getName();
        }

        public string getValue()
        {
            return Self.getValue();
        }

        public void setName(string name)
        {
            Self.setName(name);
        }

        public void setValue(string value)
        {
            Self.setValue(value);
        }

        public StandardFilter()
        {
            Implementation.Constructor();
        }

        public StandardFilter(string name, string value)
        {
            Implementation.Constructor(name, value);
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
