namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_FieldSetMember.htm#apex_class_Schema_FieldSetMember
    /// </summary>
    public class FieldSetMember
    {
        // infrastructure
        public FieldSetMember(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FieldSetMember));
            }
        }

        // API
        public bool getDBRequired()
        {
            return Self.getDBRequired();
        }

        public string getFieldPath()
        {
            return Self.getFieldPath();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public bool getRequired()
        {
            return Self.getRequired();
        }

        public DisplayType getType()
        {
            return Self.getType();
        }

        bool dbRequired
        {
            get
            {
                return Self.dbRequired;
            }
            set
            {
                Self.dbRequired = value;
            }
        }

        string fieldPath
        {
            get
            {
                return Self.fieldPath;
            }
            set
            {
                Self.fieldPath = value;
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

        bool required
        {
            get
            {
                return Self.required;
            }
            set
            {
                Self.required = value;
            }
        }

        DisplayType type
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

        public bool getDbRequired()
        {
            return Self.getDbRequired();
        }
    }
}
