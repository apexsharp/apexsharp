namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_StandardDateFilter.htm#apex_class_reports_StandardDateFilter
    /// </summary>
    public class StandardDateFilter
    {
        // infrastructure
        public StandardDateFilter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StandardDateFilter));
            }
        }

        // API
        public string getColumn()
        {
            return Self.getColumn();
        }

        public string getDurationValue()
        {
            return Self.getDurationValue();
        }

        public string getEndDate()
        {
            return Self.getEndDate();
        }

        public string getStartDate()
        {
            return Self.getStartDate();
        }

        public void setColumn(string standardDateFilterColumnName)
        {
            Self.setColumn(standardDateFilterColumnName);
        }

        public void setDurationValue(string durationName)
        {
            Self.setDurationValue(durationName);
        }

        public void setEndDate(string endDate)
        {
            Self.setEndDate(endDate);
        }

        public void setStartDate(string startDate)
        {
            Self.setStartDate(startDate);
        }

        public StandardDateFilter()
        {
            Implementation.Constructor();
        }

        public StandardDateFilter(string column, string durationValue, string startDate, string endDate)
        {
            Implementation.Constructor(column, durationValue, startDate, endDate);
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
