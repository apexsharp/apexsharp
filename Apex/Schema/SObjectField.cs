namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_SObjectField.htm#apex_class_Schema_SObjectField
    /// </summary>
    public class SObjectField
    {
        // infrastructure
        public SObjectField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SObjectField));
            }
        }

        // API
        public DescribeFieldResult getDescribe()
        {
            return Self.getDescribe();
        }
    }
}
