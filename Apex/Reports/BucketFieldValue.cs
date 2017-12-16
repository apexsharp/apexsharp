namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_BucketFieldValue.htm#apex_class_reports_BucketFieldValue
    /// </summary>
    public class BucketFieldValue
    {
        // infrastructure
        public BucketFieldValue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BucketFieldValue));
            }
        }

        // API
        public BucketFieldValue(string label, List<string> sourceDimensionValues, double rangeUpperBound)
        {
            Implementation.Constructor(label, sourceDimensionValues, rangeUpperBound);
        }

        public BucketFieldValue()
        {
            Implementation.Constructor();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public double getRangeUpperBound()
        {
            return Self.getRangeUpperBound();
        }

        public List<string> getSourceDimensionValues()
        {
            return Self.getSourceDimensionValues();
        }

        public void setLabel(string label)
        {
            Self.setLabel(label);
        }

        public void setRangeUpperBound(double rangeUpperBound)
        {
            Self.setRangeUpperBound(rangeUpperBound);
        }

        public void setSourceDimensionValues(List<string> sourceDimensionValues)
        {
            Self.setSourceDimensionValues(sourceDimensionValues);
        }

        public string toString()
        {
            return Self.toString();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
