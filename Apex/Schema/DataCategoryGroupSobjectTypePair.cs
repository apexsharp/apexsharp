namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_DataCategoryGroupSobjectTypePair.htm#apex_class_Schema_DataCategoryGroupSobjectTypePair
    /// </summary>
    public class DataCategoryGroupSobjectTypePair
    {
        // infrastructure
        public DataCategoryGroupSobjectTypePair(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DataCategoryGroupSobjectTypePair));
            }
        }

        // API
        public DataCategoryGroupSobjectTypePair()
        {
            Implementation.Constructor();
        }

        public string getDataCategoryGroupName()
        {
            return Self.getDataCategoryGroupName();
        }

        public string getSobject()
        {
            return Self.getSobject();
        }

        public string setDataCategoryGroupName(string name)
        {
            return Self.setDataCategoryGroupName(name);
        }

        public void setSobject(string sObjectName)
        {
            Self.setSobject(sObjectName);
        }

        string dataCategoryGroupName
        {
            get
            {
                return Self.dataCategoryGroupName;
            }
            set
            {
                Self.dataCategoryGroupName = value;
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
