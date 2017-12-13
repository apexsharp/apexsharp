using SysType = System.Type;

namespace Apex.System
{
    public class JSON
    {
        public JSON()
        {
            throw new global::System.NotImplementedException("JSON");
        }

        public static string serialize(object o)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(o);
        }

        public static T deserialize<T>(string jsonString)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonString);
        }

        public static object deserialize(string jsonString, SysType type)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString, type);
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("JSON.Clone");
        }

        public static JSONGenerator createGenerator(bool pretty)
        {
            throw new global::System.NotImplementedException("JSON.CreateGenerator");
        }

        public static JSONParser createParser(string jsonString)
        {
            throw new global::System.NotImplementedException("JSON.CreateParser");
        }


        public static object deserializeStrict(string jsonString, Type apexType)
        {
            throw new global::System.NotImplementedException("JSON.DeserializeStrict");
        }

        public static object deserializeUntyped(string jsonString)
        {
            throw new global::System.NotImplementedException("JSON.DeserializeUntyped");
        }



        public static string serialize(object o, bool suppressApexObjectNulls)
        {
            throw new global::System.NotImplementedException("JSON.Serialize");
        }

        public static string serializePretty(object o)
        {
            throw new global::System.NotImplementedException("JSON.SerializePretty");
        }

        public static string serializePretty(object o, bool suppressApexObjectNulls)
        {
            throw new global::System.NotImplementedException("JSON.SerializePretty");
        }
    }
}