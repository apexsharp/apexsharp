namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_RecordTypeInfo.htm#apex_class_Schema_RecordTypeInfo
    /// </summary>
    public class RecordTypeInfo
    {
        // infrastructure
        public RecordTypeInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RecordTypeInfo));
            }
        }

        // API
        public string getName()
        {
            return Self.getName();
        }

        public ID getRecordTypeId()
        {
            return Self.getRecordTypeId();
        }

        public bool isActive()
        {
            return Self.isActive();
        }

        public bool isAvailable()
        {
            return Self.isAvailable();
        }

        public bool isDefaultRecordTypeMapping()
        {
            return Self.isDefaultRecordTypeMapping();
        }

        public bool isMaster()
        {
            return Self.isMaster();
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

        bool available
        {
            get
            {
                return Self.available;
            }
            set
            {
                Self.available = value;
            }
        }

        bool defaultRecordTypeMapping
        {
            get
            {
                return Self.defaultRecordTypeMapping;
            }
            set
            {
                Self.defaultRecordTypeMapping = value;
            }
        }

        bool master
        {
            get
            {
                return Self.master;
            }
            set
            {
                Self.master = value;
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

        ID recordTypeId
        {
            get
            {
                return Self.recordTypeId;
            }
            set
            {
                Self.recordTypeId = value;
            }
        }
    }
}
