namespace Apex.Wave
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_wave_QueryBuilder.htm#apex_class_wave_QueryBuilder
    /// </summary>
    public class QueryBuilder
    {
        // infrastructure
        public QueryBuilder(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueryBuilder));
            }
        }

        // API
        public static QueryNode load(string datasetID, string datasetVersionID)
        {
            return Implementation.load(datasetID, datasetVersionID);
        }

        public static ProjectionNode count()
        {
            return Implementation.count();
        }

        public static ProjectionNode get(string proj)
        {
            return Implementation.get(proj);
        }

        [Global]
        public static QueryNode union(List<QueryNode> unionNodes)
        {
            return Implementation.union(unionNodes);
        }

        [Global]
        public static QueryNode cogroup(List<QueryNode> cogroupNodes, List<List<string>> groups)
        {
            return Implementation.cogroup(cogroupNodes, groups);
        }

        public QueryBuilder()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
