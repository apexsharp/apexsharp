namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_QueryUtils.htm#apex_class_DataSource_QueryUtils
    /// </summary>
    public class QueryUtils
    {
        // infrastructure
        public QueryUtils(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueryUtils));
            }
        }

        // API
        public static List<Map<string, object>> applyLimitAndOffset(QueryContext queryContext, List<Map<string, object>> rows)
        {
            return Implementation.applyLimitAndOffset(queryContext, rows);
        }

        public static List<Map<string, object>> filter(QueryContext queryContext, List<Map<string, object>> rows)
        {
            return Implementation.filter(queryContext, rows);
        }

        public static List<Map<string, object>> process(QueryContext queryContext, List<Map<string, object>> rows)
        {
            return Implementation.process(queryContext, rows);
        }

        public static List<Map<string, object>> sort(QueryContext queryContext, List<Map<string, object>> rows)
        {
            return Implementation.sort(queryContext, rows);
        }
    }
}
