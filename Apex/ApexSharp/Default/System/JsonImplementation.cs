using Apex.ApexSharp.Implementation;
using Apex.System;
using SysType = System.Type;
using SysDictionary = System.Collections.Generic.Dictionary<string, object>;
using Formatting = Newtonsoft.Json.Formatting;
using JsonConvert = Newtonsoft.Json.JsonConvert;
using JsonSerializerSettings = Newtonsoft.Json.JsonSerializerSettings;
using NullValueHandling = Newtonsoft.Json.NullValueHandling;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(JSON))]
    public class JsonImplementation
    {
        // Self: pointless?

        public class JsonInstance
        {
            public JSON clone() => new JSON();
        }

        // Implementation

        public dynamic Constructor() => new JsonInstance();

        private dynamic NotImplemented { get; } = new StubImplementation(typeof(JSON));

        public JSONGenerator createGenerator(bool prettyPrint) => NotImplemented.createGenerator(prettyPrint);

        public JSONParser createParser(string jsonString) => NotImplemented.createParser(jsonString);

        public object deserialize(string jsonString, Type apexType) =>
            JsonConvert.DeserializeObject(jsonString, apexType);

        public object deserializeStrict(string jsonString, Type apexType) =>
            NotImplemented.deserializeStrict(jsonString, apexType);

        public object deserializeUntyped(string jsonString)
        {
            var dictionary = JsonConvert.DeserializeObject<SysDictionary>(jsonString);
            return new Map<string, object>(dictionary);
        }

        public string serialize(object objectToSerialize) => JsonConvert.SerializeObject(objectToSerialize);

        public string serialize(object objectToSerialize, bool suppressApexObjectNulls)
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = suppressApexObjectNulls ? NullValueHandling.Ignore : NullValueHandling.Include;
            return JsonConvert.SerializeObject(objectToSerialize, settings);
        }

        public string serializePretty(object objectToSerialize) =>
            JsonConvert.SerializeObject(objectToSerialize, Formatting.Indented);

        public string serializePretty(object objectToSerialize, bool suppressApexObjectNulls)
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = suppressApexObjectNulls ? NullValueHandling.Ignore : NullValueHandling.Include;
            settings.Formatting = Formatting.Indented;
            return JsonConvert.SerializeObject(objectToSerialize, settings);
        }
    }
}
