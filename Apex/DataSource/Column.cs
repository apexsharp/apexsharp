namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_Column.htm#apex_class_DataSource_Column
    /// </summary>
    public class Column
    {
        // infrastructure
        public Column(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Column));
            }
        }

        // API
        int decimalPlaces
        {
            get
            {
                return Self.decimalPlaces;
            }
            set
            {
                Self.decimalPlaces = value;
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

        bool filterable
        {
            get
            {
                return Self.filterable;
            }
            set
            {
                Self.filterable = value;
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

        int length
        {
            get
            {
                return Self.length;
            }
            set
            {
                Self.length = value;
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

        string referenceTargetField
        {
            get
            {
                return Self.referenceTargetField;
            }
            set
            {
                Self.referenceTargetField = value;
            }
        }

        string referenceTo
        {
            get
            {
                return Self.referenceTo;
            }
            set
            {
                Self.referenceTo = value;
            }
        }

        bool sortable
        {
            get
            {
                return Self.sortable;
            }
            set
            {
                Self.sortable = value;
            }
        }

        DataType type
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

        public static Column boolean(string name)
        {
            return Implementation.boolean(name);
        }

        public static Column externalLookup(string name, string domain)
        {
            return Implementation.externalLookup(name, domain);
        }

        public static Column get(string name, string label, string description, bool isSortable, bool isFilterable, DataType type, int length, int decimalPlaces, string referenceTo, string referenceTargetField)
        {
            return Implementation.get(name, label, description, isSortable, isFilterable, type, length, decimalPlaces, referenceTo, referenceTargetField);
        }

        public static Column get(string name, string label, string description, bool isSortable, bool isFilterable, DataType type, int length, int decimalPlaces)
        {
            return Implementation.get(name, label, description, isSortable, isFilterable, type, length, decimalPlaces);
        }

        public static Column get(string name, string label, string description, bool isSortable, bool isFilterable, DataType type, int length)
        {
            return Implementation.get(name, label, description, isSortable, isFilterable, type, length);
        }

        public static Column indirectLookup(string name, string domain, string targetField)
        {
            return Implementation.indirectLookup(name, domain, targetField);
        }

        public static Column integer(string name, int length)
        {
            return Implementation.integer(name, length);
        }

        public static Column lookup(string name, string domain)
        {
            return Implementation.lookup(name, domain);
        }

        public static Column number(string name, int length, int decimalPlaces)
        {
            return Implementation.number(name, length, decimalPlaces);
        }

        public static Column text(string name, string label, int length)
        {
            return Implementation.text(name, label, length);
        }

        public static Column text(string name, int length)
        {
            return Implementation.text(name, length);
        }

        public static Column text(string name)
        {
            return Implementation.text(name);
        }

        public static Column textarea(string name)
        {
            return Implementation.textarea(name);
        }

        public static Column url(string name, int length)
        {
            return Implementation.url(name, length);
        }

        public static Column url(string name)
        {
            return Implementation.url(name);
        }
    }
}
