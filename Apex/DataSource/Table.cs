namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_Table.htm#apex_class_DataSource_Table
    /// </summary>
    public class Table
    {
        // infrastructure
        public Table(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Table));
            }
        }

        // API
        List<Column> columns
        {
            get
            {
                return Self.columns;
            }
            set
            {
                Self.columns = value;
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

        string labelPlural
        {
            get
            {
                return Self.labelPlural;
            }
            set
            {
                Self.labelPlural = value;
            }
        }

        string labelSingular
        {
            get
            {
                return Self.labelSingular;
            }
            set
            {
                Self.labelSingular = value;
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

        string nameColumn
        {
            get
            {
                return Self.nameColumn;
            }
            set
            {
                Self.nameColumn = value;
            }
        }

        public static Table get(string name, string labelSingular, string labelPlural, string description, string nameColumn, List<Column> columns)
        {
            return Implementation.get(name, labelSingular, labelPlural, description, nameColumn, columns);
        }

        public static Table get(string name, string nameColumn, List<Column> columns)
        {
            return Implementation.get(name, nameColumn, columns);
        }
    }
}
