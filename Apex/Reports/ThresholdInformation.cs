namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_ThresholdInformation.htm#apex_class_reports_ThresholdInformation
    /// </summary>
    public class ThresholdInformation
    {
        // infrastructure
        public ThresholdInformation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ThresholdInformation));
            }
        }

        // API
        public ThresholdInformation(List<EvaluatedCondition> evaluatedConditions)
        {
            Implementation.Constructor(evaluatedConditions);
        }

        public List<EvaluatedCondition> getEvaluatedConditions()
        {
            return Self.getEvaluatedConditions();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
