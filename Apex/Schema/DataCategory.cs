namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_DataCategory.htm#apex_class_Schema_DataCategory
    /// </summary>
    public class DataCategory
    {
        // infrastructure
        public DataCategory(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DataCategory));
            }
        }

        // API
        public DataCategory getChildCategories()
        {
            return Self.getChildCategories();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getName()
        {
            return Self.getName();
        }

        List<DataCategory> childCategories
        {
            get
            {
                return Self.childCategories;
            }
            set
            {
                Self.childCategories = value;
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
    }
}
