namespace Apex.Wave
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.ConnectApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_wave_QueryNode.htm#apex_class_wave_QueryNode
    /// </summary>
    public class QueryNode
    {
        // infrastructure
        public QueryNode(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueryNode));
            }
        }

        // API
        public string build(string streamName)
        {
            return Self.build(streamName);
        }

        public QueryNode @foreach(List<ProjectionNode> projections)
        {
            return Self.@foreach(projections);
        }

        public QueryNode group(List<string> groups)
        {
            return Self.group(groups);
        }

        public QueryNode group()
        {
            return Self.group();
        }

        public QueryNode cap(int cap)
        {
            return Self.cap(cap);
        }

        public QueryNode filter(string filterCondition)
        {
            return Self.filter(filterCondition);
        }

        public QueryNode filter(List<string> filterCondition)
        {
            return Self.filter(filterCondition);
        }

        public LiteralJson execute(string streamName)
        {
            return Self.execute(streamName);
        }

        public object clone()
        {
            return Self.clone();
        }

        public QueryNode order(List<List<string>> orders)
        {
            return Self.order(orders);
        }
    }
}
