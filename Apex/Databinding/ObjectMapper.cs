namespace Apex.Databinding
{
    using ApexSharp.Implementation;
    using System;

    public class ObjectMapper
    {
        // infrastructure
        public ObjectMapper(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ObjectMapper));
            }
        }

        // API
        public ObjectMapper()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static List<SObject> transform(string targetType, List<SObject> sourceRecords)
        {
            return Implementation.transform(targetType, sourceRecords);
        }

        public static List<SObject> transform(string targetType, List<SObject> sourceRecords,
            Map<String, String> fieldMapping)
        {
            return Implementation.transform(targetType, sourceRecords, fieldMapping);
        }

        public static SObject transform(string targetType, SObject sourceRecord)
        {
            return Implementation.transform(targetType, sourceRecord);
        }

        public static SObject transform(string targetType, SObject sourceRecord, Map<String, String> fieldMapping)
        {
            return Implementation.transform(targetType, sourceRecord, fieldMapping);
        }
    }
}