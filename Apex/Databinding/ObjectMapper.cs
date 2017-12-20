using Apex.System;

using SObject = Apex.System.SObject;

namespace Apex.Databinding
{
    public class ObjectMapper
    {
        public ObjectMapper()
        {
            throw new global::System.NotImplementedException("ObjectMapper");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("ObjectMapper.Clone");
        }

        public static List<SObject> transform(string targetType, List<SObject> sourceRecords)
        {
            throw new global::System.NotImplementedException("ObjectMapper.Transform");
        }

        public static List<SObject> transform(string targetType, List<SObject> sourceRecords,
            Map<String, String> fieldMapping)
        {
            throw new global::System.NotImplementedException("ObjectMapper.Transform");
        }

        public static SObject transform(string targetType, SObject sourceRecord)
        {
            throw new global::System.NotImplementedException("ObjectMapper.Transform");
        }

        public static SObject transform(string targetType, SObject sourceRecord, Map<String, String> fieldMapping)
        {
            throw new global::System.NotImplementedException("ObjectMapper.Transform");
        }
    }
}