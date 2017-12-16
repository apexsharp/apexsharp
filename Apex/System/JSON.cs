namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_System_Json.htm#apex_class_System_Json
    /// </summary>
    public class JSON
    {
        // infrastructure
        public JSON(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(JSON));
            }
        }

        // API
        public static JSONGenerator createGenerator(bool prettyPrint)
        {
            return Implementation.createGenerator(prettyPrint);
        }

        public static JSONParser createParser(string jsonString)
        {
            return Implementation.createParser(jsonString);
        }

        public static object deserialize(string jsonString, Type apexType)
        {
            return Implementation.deserialize(jsonString, apexType);
        }

        public static object deserializeStrict(string jsonString, Type apexType)
        {
            return Implementation.deserializeStrict(jsonString, apexType);
        }

        public static object deserializeUntyped(string jsonString)
        {
            return Implementation.deserializeUntyped(jsonString);
        }

        public static string serialize(object objectToSerialize)
        {
            return Implementation.serialize(objectToSerialize);
        }

        public static string serialize(object objectToSerialize, bool suppressApexObjectNulls)
        {
            return Implementation.serialize(objectToSerialize, suppressApexObjectNulls);
        }

        public static string serializePretty(object objectToSerialize)
        {
            return Implementation.serializePretty(objectToSerialize);
        }

        public static string serializePretty(object objectToSerialize, bool suppressApexObjectNulls)
        {
            return Implementation.serializePretty(objectToSerialize, suppressApexObjectNulls);
        }

        public JSON()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
