namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_DescribeDataCategoryGroupStructureResult.htm#apex_class_Schema_DescribeDataCategoryGroupStructureResult
    /// </summary>
    public class DescribeDataCategoryGroupStructureResult
    {
        // infrastructure
        public DescribeDataCategoryGroupStructureResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeDataCategoryGroupStructureResult));
            }
        }

        // API
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

        public List<DataCategory> getTopCategories()
        {
            return Self.getTopCategories();
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

        List<DataCategory> topCategories
        {
            get
            {
                return Self.topCategories;
            }
            set
            {
                Self.topCategories = value;
            }
        }
    }
}
