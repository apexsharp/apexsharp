using Apex.Schema;

namespace Apex.System
{
    public class Schema
    {
        public static List<DescribeDataCategoryGroupStructureResult> describeDataCategoryGroupStructures(
            List<DataCategoryGroupSobjectTypePair> pairs, bool topCategoriesOnly)
        {
            throw new global::System.NotImplementedException("Schema.DescribeDataCategoryGroupStructures");
        }

        public static List<DescribeDataCategoryGroupResult> describeDataCategoryGroups(List<string> sobjects)
        {
            throw new global::System.NotImplementedException("Schema.DescribeDataCategoryGroups");
        }

        public static List<DescribeSObjectResult> describeSObjects(List<string> types)
        {
            throw new global::System.NotImplementedException("Schema.DescribeSObjects");
        }

        public static List<DescribeTabSetResult> describeTabs()
        {
            throw new global::System.NotImplementedException("Schema.DescribeTabs");
        }

        public static Map<String, SObjectType> getAppDescribe(string appName)
        {
            throw new global::System.NotImplementedException("Schema.GetAppDescribe");
        }

        public static Map<String, SObjectType> getGlobalDescribe()
        {
            throw new global::System.NotImplementedException("Schema.GetGlobalDescribe");
        }

        public static Map<String, SObjectType> getModuleDescribe()
        {
            throw new global::System.NotImplementedException("Schema.GetModuleDescribe");
        }

        public static Map<String, SObjectType> getModuleDescribe(string moduleName)
        {
            throw new global::System.NotImplementedException("Schema.GetModuleDescribe");
        }
    }
}