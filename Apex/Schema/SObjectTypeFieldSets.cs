namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SObjectTypeFieldSets
    {
        // infrastructure
        public SObjectTypeFieldSets(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SObjectTypeFieldSets));
            }
        }

        // API
        public Map<string, FieldSet> getMap()
        {
            return Self.getMap();
        }
    }
}
