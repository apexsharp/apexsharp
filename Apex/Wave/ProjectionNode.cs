namespace Apex.Wave
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_wave_ProjectionNode.htm#apex_class_wave_ProjectionNode
    /// </summary>
    public class ProjectionNode
    {
        // infrastructure
        public ProjectionNode(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ProjectionNode));
            }
        }

        // API
        public ProjectionNode sum()
        {
            return Self.sum();
        }

        public ProjectionNode avg()
        {
            return Self.avg();
        }

        public ProjectionNode min()
        {
            return Self.min();
        }

        public ProjectionNode max()
        {
            return Self.max();
        }

        public ProjectionNode count()
        {
            return Self.count();
        }

        public ProjectionNode unique()
        {
            return Self.unique();
        }

        public ProjectionNode alias(string name)
        {
            return Self.alias(name);
        }

        public string build()
        {
            return Self.build();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
