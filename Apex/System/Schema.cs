namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Schema;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_schema.htm#apex_methods_system_schema
    /// </summary>
    public class Schema
    {
        // infrastructure
        public Schema(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Schema));
            }
        }

        // API
        public static Map<string, SObjectType> getGlobalDescribe()
        {
            return Implementation.getGlobalDescribe();
        }

        public static List<DescribeDataCategoryGroupResult> describeDataCategoryGroups(string sObjectNames)
        {
            return Implementation.describeDataCategoryGroups(sObjectNames);
        }

        public static List<DescribeSObjectResult> describeSObjects(List<string> sObjectTypes)
        {
            return Implementation.describeSObjects(sObjectTypes);
        }

        public static List<DescribeTabSetResult> describeTabs()
        {
            return Implementation.describeTabs();
        }

        public static List<DescribeDataCategoryGroupStructureResult> GroupStructures(List<DataCategoryGroupSobjectTypePair> pairs)
        {
            return Implementation.GroupStructures(pairs);
        }

        public static List<DescribeDataCategoryGroupResult> describeDataCategoryGroups(List<string> sobjects)
        {
            return Implementation.describeDataCategoryGroups(sobjects);
        }

        public static List<DescribeDataCategoryGroupStructureResult> describeDataCategoryGroupStructures(List<DataCategoryGroupSobjectTypePair> pairs, bool topCategoriesOnly)
        {
            return Implementation.describeDataCategoryGroupStructures(pairs, topCategoriesOnly);
        }

        public static Map<string, SObjectType> getAppDescribe(string appName)
        {
            return Implementation.getAppDescribe(appName);
        }

        public static Map<string, SObjectType> getModuleDescribe()
        {
            return Implementation.getModuleDescribe();
        }

        public static Map<string, SObjectType> getModuleDescribe(string moduleName)
        {
            return Implementation.getModuleDescribe(moduleName);
        }
    }
}
