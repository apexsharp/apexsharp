namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_DescribeDataCategoryGroupResult.htm#apex_class_Schema_DescribeDataCategoryGroupResult
    /// </summary>
    public class DescribeDataCategoryGroupResult
    {
        // infrastructure
        public DescribeDataCategoryGroupResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeDataCategoryGroupResult));
            }
        }

        // API
        public int getCategoryCount()
        {
            return Self.getCategoryCount();
        }

        public string getDescription()
        {
            return Self.getDescription();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getName()
        {
            return Self.getName();
        }

        public string getSobject()
        {
            return Self.getSobject();
        }

        int categoryCount
        {
            get
            {
                return Self.categoryCount;
            }
            set
            {
                Self.categoryCount = value;
            }
        }

        string description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
            }
        }

        string label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        string name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        string sobject
        {
            get
            {
                return Self.sobject;
            }
            set
            {
                Self.sobject = value;
            }
        }
    }
}
