namespace ApexSharpApi.Model.RestApi
{
    public class SObjectDetail
    {
        public object[] actionOverrides { get; set; }
        public bool activateable { get; set; }
        public Childrelationship[] childRelationships { get; set; }
        public bool compactLayoutable { get; set; }
        public bool createable { get; set; }
        public bool custom { get; set; }
        public bool customSetting { get; set; }
        public bool deletable { get; set; }
        public bool deprecatedAndHidden { get; set; }
        public bool feedEnabled { get; set; }
        public Field[] fields { get; set; }
        public string keyPrefix { get; set; }
        public string label { get; set; }
        public string labelPlural { get; set; }
        public bool layoutable { get; set; }
        public object listviewable { get; set; }
        public object lookupLayoutable { get; set; }
        public bool mergeable { get; set; }
        public bool mruEnabled { get; set; }
        public string name { get; set; }
        public object[] namedLayoutInfos { get; set; }
        public object networkScopeFieldName { get; set; }
        public bool queryable { get; set; }
        public Recordtypeinfo[] recordTypeInfos { get; set; }
        public bool replicateable { get; set; }
        public bool retrieveable { get; set; }
        public bool searchLayoutable { get; set; }
        public bool searchable { get; set; }
        public Supportedscope[] supportedScopes { get; set; }
        public bool triggerable { get; set; }
        public bool undeletable { get; set; }
        public bool updateable { get; set; }
        public Urls urls { get; set; }
    }

    public class Urls
    {
        public string compactLayouts { get; set; }
        public string rowTemplate { get; set; }
        public string approvalLayouts { get; set; }
        public string uiDetailTemplate { get; set; }
        public string uiEditTemplate { get; set; }
        public string defaultValues { get; set; }
        public string describe { get; set; }
        public string uiNewRecord { get; set; }
        public string quickActions { get; set; }
        public string layouts { get; set; }
        public string sobject { get; set; }
    }

    public class Childrelationship
    {
        public bool cascadeDelete { get; set; }
        public string childSObject { get; set; }
        public bool deprecatedAndHidden { get; set; }
        public string field { get; set; }
        public object[] junctionIdListNames { get; set; }
        public object[] junctionReferenceTo { get; set; }
        public string relationshipName { get; set; }
        public bool restrictedDelete { get; set; }
    }

    public class Field
    {
        public bool aggregatable { get; set; }
        public bool autoNumber { get; set; }
        public int byteLength { get; set; }
        public bool calculated { get; set; }
        public object calculatedFormula { get; set; }
        public bool cascadeDelete { get; set; }
        public bool caseSensitive { get; set; }
        public object controllerName { get; set; }
        public bool createable { get; set; }
        public bool custom { get; set; }
        public object defaultValue { get; set; }
        public object defaultValueFormula { get; set; }
        public bool defaultedOnCreate { get; set; }
        public bool dependentPicklist { get; set; }
        public bool deprecatedAndHidden { get; set; }
        public int digits { get; set; }
        public bool displayLocationInDecimal { get; set; }
        public bool encrypted { get; set; }
        public bool externalId { get; set; }
        public object extraTypeInfo { get; set; }
        public bool filterable { get; set; }
        public object filteredLookupInfo { get; set; }
        public bool groupable { get; set; }
        public bool highScaleNumber { get; set; }
        public bool htmlFormatted { get; set; }
        public bool idLookup { get; set; }
        public object inlineHelpText { get; set; }
        public string label { get; set; }
        public int length { get; set; }
        public object mask { get; set; }
        public object maskType { get; set; }
        public string name { get; set; }
        public bool nameField { get; set; }
        public bool namePointing { get; set; }
        public bool nillable { get; set; }
        public bool permissionable { get; set; }
        public object[] picklistValues { get; set; }
        public int precision { get; set; }
        public bool queryByDistance { get; set; }
        public object referenceTargetField { get; set; }
        public string[] referenceTo { get; set; }
        public string relationshipName { get; set; }
        public object relationshipOrder { get; set; }
        public bool restrictedDelete { get; set; }
        public bool restrictedPicklist { get; set; }
        public int scale { get; set; }
        public string soapType { get; set; }
        public bool sortable { get; set; }
        public string type { get; set; }
        public bool unique { get; set; }
        public bool updateable { get; set; }
        public bool writeRequiresMasterRead { get; set; }
    }

    public class Recordtypeinfo
    {
        public bool available { get; set; }
        public bool defaultRecordTypeMapping { get; set; }
        public bool master { get; set; }
        public string name { get; set; }
        public string recordTypeId { get; set; }
        public Urls1 urls { get; set; }
    }

    public class Urls1
    {
        public string layout { get; set; }
    }

    public class Supportedscope
    {
        public string label { get; set; }
        public string name { get; set; }
    }
}