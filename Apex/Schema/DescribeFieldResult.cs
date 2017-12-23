namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_fields_describe.htm#apex_methods_system_fields_describe
    /// </summary>
    public class DescribeFieldResult
    {
        // infrastructure
        public DescribeFieldResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeFieldResult));
            }
        }

        // API
        public int getByteLength()
        {
            return Self.getByteLength();
        }

        public string getCalculatedFormula()
        {
            return Self.getCalculatedFormula();
        }

        public SObjectField getController()
        {
            return Self.getController();
        }

        public object getDefaultValue()
        {
            return Self.getDefaultValue();
        }

        public string getDefaultValueFormula()
        {
            return Self.getDefaultValueFormula();
        }

        public int getDigits()
        {
            return Self.getDigits();
        }

        public string getInlineHelpText()
        {
            return Self.getInlineHelpText();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public int getLength()
        {
            return Self.getLength();
        }

        public string getLocalName()
        {
            return Self.getLocalName();
        }

        public string getName()
        {
            return Self.getName();
        }

        public List<PicklistEntry> getPicklistValues()
        {
            return Self.getPicklistValues();
        }

        public int getPrecision()
        {
            return Self.getPrecision();
        }

        public string getReferenceTargetField()
        {
            return Self.getReferenceTargetField();
        }

        public List<SObjectType> getReferenceTo()
        {
            return Self.getReferenceTo();
        }

        public string getRelationshipName()
        {
            return Self.getRelationshipName();
        }

        public int getRelationshipOrder()
        {
            return Self.getRelationshipOrder();
        }

        public int getScale()
        {
            return Self.getScale();
        }

        public SoapType getSOAPType()
        {
            return Self.getSOAPType();
        }

        public SObjectField getSObjectField()
        {
            return Self.getSObjectField();
        }

        public DisplayType getType()
        {
            return Self.getType();
        }

        public bool isAccessible()
        {
            return Self.isAccessible();
        }

        public bool isAutoNumber()
        {
            return Self.isAutoNumber();
        }

        public bool isCalculated()
        {
            return Self.isCalculated();
        }

        public bool isCascadeDelete()
        {
            return Self.isCascadeDelete();
        }

        public bool isCaseSensitive()
        {
            return Self.isCaseSensitive();
        }

        public bool isCreateable()
        {
            return Self.isCreateable();
        }

        public bool isCustom()
        {
            return Self.isCustom();
        }

        public bool isDefaultedOnCreate()
        {
            return Self.isDefaultedOnCreate();
        }

        public bool isDependentPicklist()
        {
            return Self.isDependentPicklist();
        }

        public bool isDeprecatedAndHidden()
        {
            return Self.isDeprecatedAndHidden();
        }

        public bool isExternalID()
        {
            return Self.isExternalID();
        }

        public bool isFilterable()
        {
            return Self.isFilterable();
        }

        public bool isGroupable()
        {
            return Self.isGroupable();
        }

        public bool isHtmlFormatted()
        {
            return Self.isHtmlFormatted();
        }

        public bool isIdLookup()
        {
            return Self.isIdLookup();
        }

        public bool isNameField()
        {
            return Self.isNameField();
        }

        public bool isNamePointing()
        {
            return Self.isNamePointing();
        }

        public bool isNillable()
        {
            return Self.isNillable();
        }

        public bool isPermissionable()
        {
            return Self.isPermissionable();
        }

        public bool isRestrictedDelete()
        {
            return Self.isRestrictedDelete();
        }

        public bool isRestrictedPicklist()
        {
            return Self.isRestrictedPicklist();
        }

        public bool isSearchPrefilterable()
        {
            return Self.isSearchPrefilterable();
        }

        public bool isSortable()
        {
            return Self.isSortable();
        }

        public bool isUnique()
        {
            return Self.isUnique();
        }

        public bool isUpdateable()
        {
            return Self.isUpdateable();
        }

        public bool isWriteRequiresMasterRead()
        {
            return Self.isWriteRequiresMasterRead();
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

        bool aggregatable
        {
            get
            {
                return Self.aggregatable;
            }
            set
            {
                Self.aggregatable = value;
            }
        }

        bool autoNumber
        {
            get
            {
                return Self.autoNumber;
            }
            set
            {
                Self.autoNumber = value;
            }
        }

        int byteLength
        {
            get
            {
                return Self.byteLength;
            }
            set
            {
                Self.byteLength = value;
            }
        }

        bool calculated
        {
            get
            {
                return Self.calculated;
            }
            set
            {
                Self.calculated = value;
            }
        }

        string calculatedFormula
        {
            get
            {
                return Self.calculatedFormula;
            }
            set
            {
                Self.calculatedFormula = value;
            }
        }

        bool cascadeDelete
        {
            get
            {
                return Self.cascadeDelete;
            }
            set
            {
                Self.cascadeDelete = value;
            }
        }

        bool caseSensitive
        {
            get
            {
                return Self.caseSensitive;
            }
            set
            {
                Self.caseSensitive = value;
            }
        }

        string compoundFieldName
        {
            get
            {
                return Self.compoundFieldName;
            }
            set
            {
                Self.compoundFieldName = value;
            }
        }

        SObjectField controller
        {
            get
            {
                return Self.controller;
            }
            set
            {
                Self.controller = value;
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

        bool defaultedOnCreate
        {
            get
            {
                return Self.defaultedOnCreate;
            }
            set
            {
                Self.defaultedOnCreate = value;
            }
        }

        object defaultValue
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

        string defaultValueFormula
        {
            get
            {
                return Self.defaultValueFormula;
            }
            set
            {
                Self.defaultValueFormula = value;
            }
        }

        bool dependentPicklist
        {
            get
            {
                return Self.dependentPicklist;
            }
            set
            {
                Self.dependentPicklist = value;
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

        int digits
        {
            get
            {
                return Self.digits;
            }
            set
            {
                Self.digits = value;
            }
        }

        bool displayLocationInDecimal
        {
            get
            {
                return Self.displayLocationInDecimal;
            }
            set
            {
                Self.displayLocationInDecimal = value;
            }
        }

        bool encrypted
        {
            get
            {
                return Self.encrypted;
            }
            set
            {
                Self.encrypted = value;
            }
        }

        bool externalId
        {
            get
            {
                return Self.externalId;
            }
            set
            {
                Self.externalId = value;
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

        FilteredLookupInfo filteredLookupInfo
        {
            get
            {
                return Self.filteredLookupInfo;
            }
            set
            {
                Self.filteredLookupInfo = value;
            }
        }

        bool groupable
        {
            get
            {
                return Self.groupable;
            }
            set
            {
                Self.groupable = value;
            }
        }

        bool highScaleNumber
        {
            get
            {
                return Self.highScaleNumber;
            }
            set
            {
                Self.highScaleNumber = value;
            }
        }

        bool htmlFormatted
        {
            get
            {
                return Self.htmlFormatted;
            }
            set
            {
                Self.htmlFormatted = value;
            }
        }

        bool idLookup
        {
            get
            {
                return Self.idLookup;
            }
            set
            {
                Self.idLookup = value;
            }
        }

        string inlineHelpText
        {
            get
            {
                return Self.inlineHelpText;
            }
            set
            {
                Self.inlineHelpText = value;
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

        string mask
        {
            get
            {
                return Self.mask;
            }
            set
            {
                Self.mask = value;
            }
        }

        string maskType
        {
            get
            {
                return Self.maskType;
            }
            set
            {
                Self.maskType = value;
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

        bool nameField
        {
            get
            {
                return Self.nameField;
            }
            set
            {
                Self.nameField = value;
            }
        }

        bool namePointing
        {
            get
            {
                return Self.namePointing;
            }
            set
            {
                Self.namePointing = value;
            }
        }

        bool nillable
        {
            get
            {
                return Self.nillable;
            }
            set
            {
                Self.nillable = value;
            }
        }

        bool permissionable
        {
            get
            {
                return Self.permissionable;
            }
            set
            {
                Self.permissionable = value;
            }
        }

        List<PicklistEntry> picklistValues
        {
            get
            {
                return Self.picklistValues;
            }
            set
            {
                Self.picklistValues = value;
            }
        }

        int precision
        {
            get
            {
                return Self.precision;
            }
            set
            {
                Self.precision = value;
            }
        }

        bool queryByDistance
        {
            get
            {
                return Self.queryByDistance;
            }
            set
            {
                Self.queryByDistance = value;
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

        List<SObjectType> referenceTo
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

        string relationshipName
        {
            get
            {
                return Self.relationshipName;
            }
            set
            {
                Self.relationshipName = value;
            }
        }

        int relationshipOrder
        {
            get
            {
                return Self.relationshipOrder;
            }
            set
            {
                Self.relationshipOrder = value;
            }
        }

        bool restrictedDelete
        {
            get
            {
                return Self.restrictedDelete;
            }
            set
            {
                Self.restrictedDelete = value;
            }
        }

        bool restrictedPicklist
        {
            get
            {
                return Self.restrictedPicklist;
            }
            set
            {
                Self.restrictedPicklist = value;
            }
        }

        int scale
        {
            get
            {
                return Self.scale;
            }
            set
            {
                Self.scale = value;
            }
        }

        bool searchPrefilterable
        {
            get
            {
                return Self.searchPrefilterable;
            }
            set
            {
                Self.searchPrefilterable = value;
            }
        }

        SoapType soapType
        {
            get
            {
                return Self.soapType;
            }
            set
            {
                Self.soapType = value;
            }
        }

        SObjectField sobjectField
        {
            get
            {
                return Self.sobjectField;
            }
            set
            {
                Self.sobjectField = value;
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

        bool unique
        {
            get
            {
                return Self.unique;
            }
            set
            {
                Self.unique = value;
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

        bool writeRequiresMasterRead
        {
            get
            {
                return Self.writeRequiresMasterRead;
            }
            set
            {
                Self.writeRequiresMasterRead = value;
            }
        }

        public string getCompoundFieldName()
        {
            return Self.getCompoundFieldName();
        }

        public FilteredLookupInfo getFilteredLookupInfo()
        {
            return Self.getFilteredLookupInfo();
        }

        public string getMask()
        {
            return Self.getMask();
        }

        public string getMaskType()
        {
            return Self.getMaskType();
        }

        public SoapType getSoapType()
        {
            return Self.getSoapType();
        }

        public SObjectField getSobjectField()
        {
            return Self.getSobjectField();
        }

        public bool isAggregatable()
        {
            return Self.isAggregatable();
        }

        public bool isDisplayLocationInDecimal()
        {
            return Self.isDisplayLocationInDecimal();
        }

        public bool isEncrypted()
        {
            return Self.isEncrypted();
        }

        public bool isExternalId()
        {
            return Self.isExternalId();
        }

        public bool isHighScaleNumber()
        {
            return Self.isHighScaleNumber();
        }

        public bool isQueryByDistance()
        {
            return Self.isQueryByDistance();
        }
    }
}
