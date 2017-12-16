namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ReportInstanceAttributes
    {
        // infrastructure
        public ReportInstanceAttributes(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportInstanceAttributes));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public Datetime getCompletionDate()
        {
            return Self.getCompletionDate();
        }

        public ID getId()
        {
            return Self.getId();
        }

        public ID getOwnerId()
        {
            return Self.getOwnerId();
        }

        public Datetime getRequestDate()
        {
            return Self.getRequestDate();
        }

        public string getStatus()
        {
            return Self.getStatus();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
