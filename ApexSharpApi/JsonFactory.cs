using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace ApexSharpApi
{
    public class JsonFactory
    {
        // We need a Json String that does not pass values that cant be updated on SF plus format the Date to SF
        public static string GetJson(Object record)
        {
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            };

            serializerSettings.Converters.Add(new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ" });


            string requestJson = JsonConvert.SerializeObject(record, Formatting.Indented, serializerSettings);

            var jObject = (JObject)JsonConvert.DeserializeObject(requestJson);


            jObject.Remove("Id"); // type is "ID", field is "Id"
            jObject.Remove("OwnerId");
            jObject.Remove("IsDeleted");
            jObject.Remove("CreatedDate");
            jObject.Remove("CreatedById");
            jObject.Remove("LastModifiedDate");
            jObject.Remove("LastModifiedById");
            jObject.Remove("LastModifiedByBy");
            jObject.Remove("SystemModstamp");
            jObject.Remove("LastViewedDate");
            jObject.Remove("LastReferencedDate");
            jObject.Remove("IsEmailBounced");
            jObject.Remove("Birthdate");

            requestJson = jObject.ToString();

            return requestJson;
        }

        public static string GetJsonUpdate(Object record)
        {
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            };

            serializerSettings.Converters.Add(new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ" });


            string requestJson = JsonConvert.SerializeObject(record, Formatting.Indented, serializerSettings);

            var jObject = (JObject)JsonConvert.DeserializeObject(requestJson);


            jObject.Remove("Id"); // type is "ID", field is "Id"
            jObject.Remove("Name");
            jObject.Remove("OwnerId");
            jObject.Remove("IsDeleted");
            jObject.Remove("CreatedDate");
            jObject.Remove("CreatedById");
            jObject.Remove("LastModifiedDate");
            jObject.Remove("LastModifiedById");
            jObject.Remove("LastModifiedByBy");
            jObject.Remove("SystemModstamp");
            jObject.Remove("LastViewedDate");
            jObject.Remove("LastReferencedDate");
            jObject.Remove("IsEmailBounced");



            requestJson = jObject.ToString();

            return requestJson;
        }
    }
}