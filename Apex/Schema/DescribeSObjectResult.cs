namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_sobject_describe.htm#apex_methods_system_sobject_describe
    /// </summary>
    public class DescribeSObjectResult
    {
        // infrastructure
        public DescribeSObjectResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeSObjectResult));
            }
        }

        // API
        public ChildRelationship getChildRelationships()
        {
            return Self.getChildRelationships();
        }

        public bool getHasSubtypes()
        {
            return Self.getHasSubtypes();
        }

        public string getKeyPrefix()
        {
            return Self.getKeyPrefix();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getLabelPlural()
        {
            return Self.getLabelPlural();
        }

        public string getLocalName()
        {
            return Self.getLocalName();
        }

        public string getName()
        {
            return Self.getName();
        }

        public List<RecordTypeInfo> getRecordTypeInfos()
        {
            return Self.getRecordTypeInfos();
        }

        public RecordTypeInfo getRecordTypeInfosById()
        {
            return Self.getRecordTypeInfosById();
        }

        public RecordTypeInfo getRecordTypeInfosByName()
        {
            return Self.getRecordTypeInfosByName();
        }

        public SObjectType getSobjectType()
        {
            return Self.getSobjectType();
        }

        public bool isAccessible()
        {
            return Self.isAccessible();
        }

        public bool isCreateable()
        {
            return Self.isCreateable();
        }

        public bool isCustom()
        {
            return Self.isCustom();
        }

        public bool isCustomSetting()
        {
            return Self.isCustomSetting();
        }

        public bool isDeletable()
        {
            return Self.isDeletable();
        }

        public bool isDeprecatedAndHidden()
        {
            return Self.isDeprecatedAndHidden();
        }

        public bool isFeedEnabled()
        {
            return Self.isFeedEnabled();
        }

        public bool isMergeable()
        {
            return Self.isMergeable();
        }

        public bool isMruEnabled()
        {
            return Self.isMruEnabled();
        }

        public bool isQueryable()
        {
            return Self.isQueryable();
        }

        public bool isSearchable()
        {
            return Self.isSearchable();
        }

        public bool isUndeletable()
        {
            return Self.isUndeletable();
        }

        public bool isUpdateable()
        {
            return Self.isUpdateable();
        }

        bool accessible
        {
            get
            {
                return Self.accessible;
            }
            set
            {
                Self.accessible = value;
            }
        }

        List<ChildRelationship> childRelationships
        {
            get
            {
                return Self.childRelationships;
            }
            set
            {
                Self.childRelationships = value;
            }
        }

        bool createable
        {
            get
            {
                return Self.createable;
            }
            set
            {
                Self.createable = value;
            }
        }

        bool custom
        {
            get
            {
                return Self.custom;
            }
            set
            {
                Self.custom = value;
            }
        }

        bool customSetting
        {
            get
            {
                return Self.customSetting;
            }
            set
            {
                Self.customSetting = value;
            }
        }

        bool deletable
        {
            get
            {
                return Self.deletable;
            }
            set
            {
                Self.deletable = value;
            }
        }

        bool deprecatedAndHidden
        {
            get
            {
                return Self.deprecatedAndHidden;
            }
            set
            {
                Self.deprecatedAndHidden = value;
            }
        }

        bool feedEnabled
        {
            get
            {
                return Self.feedEnabled;
            }
            set
            {
                Self.feedEnabled = value;
            }
        }

        [Final]
        static SObjectTypeFields fields
        {
            get
            {
                return Implementation.fields;
            }
        }

        [Final]
        static SObjectTypeFieldSets fieldSets
        {
            get
            {
                return Implementation.fieldSets;
            }
        }

        bool hasSubtypes
        {
            get
            {
                return Self.hasSubtypes;
            }
            set
            {
                Self.hasSubtypes = value;
            }
        }

        bool isSubtype
        {
            get
            {
                return Self.isSubtype;
            }
            set
            {
                Self.isSubtype = value;
            }
        }

        string keyPrefix
        {
            get
            {
                return Self.keyPrefix;
            }
            set
            {
                Self.keyPrefix = value;
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

        string localName
        {
            get
            {
                return Self.localName;
            }
            set
            {
                Self.localName = value;
            }
        }

        bool mergeable
        {
            get
            {
                return Self.mergeable;
            }
            set
            {
                Self.mergeable = value;
            }
        }

        bool mruEnabled
        {
            get
            {
                return Self.mruEnabled;
            }
            set
            {
                Self.mruEnabled = value;
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

        bool queryable
        {
            get
            {
                return Self.queryable;
            }
            set
            {
                Self.queryable = value;
            }
        }

        List<RecordTypeInfo> recordTypeInfos
        {
            get
            {
                return Self.recordTypeInfos;
            }
            set
            {
                Self.recordTypeInfos = value;
            }
        }

        Map<ID, RecordTypeInfo> recordTypeInfosById
        {
            get
            {
                return Self.recordTypeInfosById;
            }
            set
            {
                Self.recordTypeInfosById = value;
            }
        }

        Map<string, RecordTypeInfo> recordTypeInfosByName
        {
            get
            {
                return Self.recordTypeInfosByName;
            }
            set
            {
                Self.recordTypeInfosByName = value;
            }
        }

        bool searchable
        {
            get
            {
                return Self.searchable;
            }
            set
            {
                Self.searchable = value;
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

        bool undeletable
        {
            get
            {
                return Self.undeletable;
            }
            set
            {
                Self.undeletable = value;
            }
        }

        bool updateable
        {
            get
            {
                return Self.updateable;
            }
            set
            {
                Self.updateable = value;
            }
        }

        public SObjectTypeFields getFields()
        {
            return Self.getFields();
        }

        public SObjectTypeFieldSets getFieldSets()
        {
            return Self.getFieldSets();
        }

        public bool getIsSubtype()
        {
            return Self.getIsSubtype();
        }

        public SObjectType getSObjectType()
        {
            return Self.getSObjectType();
        }
    }
}
