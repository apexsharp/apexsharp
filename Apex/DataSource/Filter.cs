namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_Filter.htm#apex_class_DataSource_Filter
    /// </summary>
    public class Filter
    {
        // infrastructure
        public Filter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Filter));
            }
        }

        // API
        string columnName
        {
            get
            {
                return Self.columnName;
            }
            set
            {
                Self.columnName = value;
            }
        }

        object columnValue
        {
            get
            {
                return Self.columnValue;
            }
            set
            {
                Self.columnValue = value;
            }
        }

        List<Filter> subfilters
        {
            get
            {
                return Self.subfilters;
            }
            set
            {
                Self.subfilters = value;
            }
        }

        string tableName
        {
            get
            {
                return Self.tableName;
            }
            set
            {
                Self.tableName = value;
            }
        }

        FilterType type
        {
            get
            {
                return Self.type;
            }
            set
            {
                Self.type = value;
            }
        }
    }
}
