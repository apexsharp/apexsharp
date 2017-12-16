namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_PicklistEntry.htm#apex_class_Schema_PicklistEntry
    /// </summary>
    public class PicklistEntry
    {
        // infrastructure
        public PicklistEntry(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PicklistEntry));
            }
        }

        // API
        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getValue()
        {
            return Self.getValue();
        }

        public bool isActive()
        {
            return Self.isActive();
        }

        public bool isDefaultValue()
        {
            return Self.isDefaultValue();
        }

        bool active
        {
            get
            {
                return Self.active;
            }
            set
            {
                Self.active = value;
            }
        }

        bool defaultValue
        {
            get
            {
                return Self.defaultValue;
            }
            set
            {
                Self.defaultValue = value;
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

        string value
        {
            get
            {
                return Self.value;
            }
            set
            {
                Self.value = value;
            }
        }
    }
}
