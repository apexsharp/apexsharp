namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_BucketField.htm#apex_class_reports_BucketField
    /// </summary>
    public class BucketField
    {
        // infrastructure
        public BucketField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BucketField));
            }
        }

        // API
        public BucketField(BucketType bucketType, string devloperName, string label, bool nullTreatedAsZero, string otherBucketLabel, string sourceColumnName, List<BucketFieldValue> values)
        {
            Implementation.Constructor(bucketType, devloperName, label, nullTreatedAsZero, otherBucketLabel, sourceColumnName, values);
        }

        public BucketField()
        {
            Implementation.Constructor();
        }

        public BucketType getBucketType()
        {
            return Self.getBucketType();
        }

        public string getDevloperName()
        {
            return Self.getDevloperName();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public bool getNullTreatedAsZero()
        {
            return Self.getNullTreatedAsZero();
        }

        public string getOtherBucketLabel()
        {
            return Self.getOtherBucketLabel();
        }

        public string getSourceColumnName()
        {
            return Self.getSourceColumnName();
        }

        public List<BucketFieldValue> getValues()
        {
            return Self.getValues();
        }

        public void setBucketType(string value)
        {
            Self.setBucketType(value);
        }

        public void setBucketType(BucketType bucketType)
        {
            Self.setBucketType(bucketType);
        }

        public void setDevloperName(string devloperName)
        {
            Self.setDevloperName(devloperName);
        }

        public void setLabel(string label)
        {
            Self.setLabel(label);
        }

        public void setNullTreatedAsZero(bool nullTreatedAsZero)
        {
            Self.setNullTreatedAsZero(nullTreatedAsZero);
        }

        public void setOtherBucketLabel(string otherBucketLabel)
        {
            Self.setOtherBucketLabel(otherBucketLabel);
        }

        public void setSourceColumnName(string sourceColumnName)
        {
            Self.setSourceColumnName(sourceColumnName);
        }

        public void setValues(List<BucketFieldValue> values)
        {
            Self.setValues(values);
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
