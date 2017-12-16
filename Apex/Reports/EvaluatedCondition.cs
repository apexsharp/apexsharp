namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_EvaluatedCondition.htm#apex_class_reports_EvaluatedCondition
    /// </summary>
    public class EvaluatedCondition
    {
        // infrastructure
        public EvaluatedCondition(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EvaluatedCondition));
            }
        }

        // API
        public EvaluatedCondition(string aggregateName, string aggregateLabel, double compareToValue, double aggregateValue, string displayCompareTo, string displayValue, EvaluatedConditionOperator @operator)
        {
            Implementation.Constructor(aggregateName, aggregateLabel, compareToValue, aggregateValue, displayCompareTo, displayValue, @operator);
        }

        public string getAggregateLabel()
        {
            return Self.getAggregateLabel();
        }

        public string getAggregateName()
        {
            return Self.getAggregateName();
        }

        public double getCompareTo()
        {
            return Self.getCompareTo();
        }

        public string getDisplayCompareTo()
        {
            return Self.getDisplayCompareTo();
        }

        public string getDisplayValue()
        {
            return Self.getDisplayValue();
        }

        public EvaluatedConditionOperator getOperator()
        {
            return Self.getOperator();
        }

        public double getValue()
        {
            return Self.getValue();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
