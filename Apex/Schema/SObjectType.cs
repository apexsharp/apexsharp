namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;
    using ApexSharpApi.ApexApi;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_SObjectType.htm#apex_class_Schema_SObjectType
    /// </summary>
    public class SObjectType
    {
        // infrastructure
        public SObjectType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SObjectType));
            }
        }

        // API
        public DescribeSObjectResult getDescribe()
        {
            return Self.getDescribe();
        }

        public SObject newSObject()
        {
            return Self.newSObject();
        }

        public SObject newSObject(ID id)
        {
            return Self.newSObject(id);
        }

        public SObject newSObject(ID recordTypeId, bool loadDefaults)
        {
            return Self.newSObject(recordTypeId, loadDefaults);
        }

        [Final]
        static SObjectTypeFields fields
        {
            get
            {
                return Implementation.fields;
            }
            set
            {
                Implementation.fields = value;
            }
        }
    }
}
