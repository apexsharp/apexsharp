using System;
using System.Linq;
using System.Reflection;
using ApexSharpApi.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace ApexSharpApi
{
    public class JsonFactory
    {
        // We need a Json String that does not pass values that cant be updated on SF plus format the Date to SF
        public static string GetJsonForInsert(Object record)
        {
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            };

            serializerSettings.Converters.Add(new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ" });


            string requestJson = JsonConvert.SerializeObject(record, Formatting.Indented, serializerSettings);

            var jObject = (JObject)JsonConvert.DeserializeObject(requestJson);


            // Do not send these fields in JSON as they cant be inserted into SF
            jObject.Remove("ExternalId");
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
            jObject.Remove("EmailBouncedDate");
            jObject.Remove("LastActivityDate");
            jObject.Remove("LastCUUpdateDate");
            jObject.Remove("LastCURequestDate");

            // remove properties marked as IgnoreUpdates
            foreach (var prop in GetIgnoredProperties(record))
            {
                jObject.Remove(prop);
            }

            requestJson = jObject.ToString();

            return requestJson;
        }

        public static string GetJsonForUpdate(Object record)
        {
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            };

            serializerSettings.Converters.Add(new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ" });


            string requestJson = JsonConvert.SerializeObject(record, Formatting.Indented, serializerSettings);

            var jObject = (JObject)JsonConvert.DeserializeObject(requestJson);

            // Do not send these fields in JSON as they cant be updated on SF
            jObject.Remove("Id");
            jObject.Remove("ExternalId");
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
            jObject.Remove("EmailBouncedDate");
            jObject.Remove("LastActivityDate");
            jObject.Remove("LastCUUpdateDate");
            jObject.Remove("LastCURequestDate");

            // remove properties marked as IgnoreUpdates
            foreach (var prop in GetIgnoredProperties(record))
            {
                jObject.Remove(prop);
            }

            requestJson = jObject.ToString();

            return requestJson;
        }

        internal static string[] GetIgnoredProperties(object record)
        {
            if (record == null)
            {
                return new string[0];
            }

            bool IgnoreUpdates(PropertyInfo pi) =>
                pi.GetCustomAttributes(false).OfType<IgnoreUpdateAttribute>().Any();

            var properties = record.GetType().GetProperties();
            return properties.Where(pi => IgnoreUpdates(pi)).Select(pi => pi.Name).ToArray();
        }
    }
}