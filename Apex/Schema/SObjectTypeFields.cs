namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SObjectTypeFields
    {
        // infrastructure
        public SObjectTypeFields(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SObjectTypeFields));
            }
        }

        // API
        public Map<string, DescribeFieldResult> getMap()
        {
            return Self.getMap();
        }
    }
}
