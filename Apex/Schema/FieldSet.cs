namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_fieldsets_describe.htm#apex_methods_system_fieldsets_describe
    /// </summary>
    public class FieldSet
    {
        // infrastructure
        public FieldSet(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FieldSet));
            }
        }

        // API
        public string getDescription()
        {
            return Self.getDescription();
        }

        public List<FieldSetMember> getFields()
        {
            return Self.getFields();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getName()
        {
            return Self.getName();
        }

        public string getNamespace()
        {
            return Self.getNamespace();
        }

        public SObjectType getSObjectType()
        {
            return Self.getSObjectType();
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

        List<FieldSetMember> fields
        {
            get
            {
                return Self.fields;
            }
            set
            {
                Self.fields = value;
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

        string nameSpace
        {
            get
            {
                return Self.nameSpace;
            }
            set
            {
                Self.nameSpace = value;
            }
        }

        SObjectType SObjectType
        {
            get
            {
                return Self.SObjectType;
            }
            set
            {
                Self.SObjectType = value;
            }
        }

        public string getNameSpace()
        {
            return Self.getNameSpace();
        }
    }
}
