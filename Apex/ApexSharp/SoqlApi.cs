using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Apex.System;
using ApexSharpApi;
using ApexSharpApi.Model.RestApi;
using Newtonsoft.Json;
using Serilog;

namespace Apex.ApexSharp
{
    public class SoqlApi
    {
        // ToDo: Need to use a single list..may be move to a util class.
        private static readonly Dictionary<string, string> FieldDictionary = new Dictionary<string, string>
        {
            {"address", "Address" },
            {"id","ID" },
            {"string","string" },
            {"picklist","string" },
            {"email","string" },
            {"textarea","string" },
            {"phone","string" },
            {"url","string" },
            {"combobox","string" },
            {"multipicklist","string" },
            {"anytype","object" },
            {"location","string" },
            {"boolean","bool" },
            {"datetime","Datetime" },
            {"time","Datetime" },
            {"date","Datetime" },
            {"currency","double" },
            {"percent","double" },
            {"double","double" },
            {"int","int" },
            {"anyType", "object" },
            {"base64", "string" },
            {"complexvalue", "string" }
        };

        private static string GetSoql<T>(int limit)
        {
            global::System.Collections.Generic.List<string> supportedTypes =
                new global::System.Collections.Generic.List<string> {"Boolean", "String", "Datetime", "DateTime", "Double", "Int32"};

            StringBuilder sb = new StringBuilder();
            var memberProperties = typeof(T).GetProperties().ToList();

            sb.Append("SELECT ");

            foreach (var memberProperty in memberProperties)
            {
                //Console.WriteLine(memberProperty.PropertyType.Name + " : " + memberProperty.Name);

                if(supportedTypes.Contains(memberProperty.PropertyType.Name) && memberProperty.Name != "ExternalId")
                {
                    sb.Append(memberProperty.Name).Append(',');
                }
            }

            var soql = sb.ToString();
            // Remove the last comma
            soql = soql.TrimEnd(',');
            soql = soql + " FROM " + typeof(T).Name + " LIMIT " + limit;


            return soql;
        }

        public static SoqlQuery<T> Query<T>(int limit) where T : SObject
        {
            // prepare query text
            var soql = GetSoql<T>(limit);


            // prepare query result
            var lasyResult = new Lazy<global::System.Collections.Generic.List<T>>(() =>
            {
                return PerformQuery<T>(soql);
            });

            // return as polymorphic query instance
            return new SoqlQuery<T>(lasyResult, soql);
        }

        public static SoqlQuery<T> Query<T>(string soql, params object[] parameters)
        {
            // prepare query result
            var newSoql = ConvertSoql(soql, parameters);
            var lasyResult = new Lazy<global::System.Collections.Generic.List<T>>(() =>
            {
                return PerformQuery<T>(newSoql);
            });

            // return as polymorphic query instance
            return new SoqlQuery<T>(lasyResult, soql, newSoql, parameters);
        }

        public static string ConvertSoql(string soql, params object[] param)
        {
            var matches = Regex.Matches(soql, "(\\:\\S+)");
            if (matches.Count == param.Length)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    if (param[i].GetType().Name == "Int32")
                    {
                        soql = soql.Replace(matches[i].Value, " " + param[i] + " ");
                    }
                    else
                    {
                        soql = soql.Replace(matches[i].Value, "'" + param[i] + "'");
                    }
                }
            }
            else
            {
                Log.Logger.Error("Fail in ConvertSoql");
            }
            return soql;
        }

        private static global::System.Collections.Generic.List<T> PerformQuery<T>(string query)
        {
            Log.ForContext<SoqlApi>().Debug("SOQL Query {query}", query);

            HttpManager httpManager = new HttpManager();
            var json = httpManager.Get($"query/?q={query}");

            RecordReadList<T> returnData = JsonConvert.DeserializeObject<RecordReadList<T>>(json,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            return returnData.records;
        }


        public static T Insert<T>(T obj) where T : SObject
        {
            var jsonData = JsonFactory.GetJsonForInsert(obj);

            var objectName = typeof(T).Name;
            HttpManager httpManager = new HttpManager();
            jsonData = httpManager.Post($"sobjects/{objectName}/", jsonData);
            RecordCreateResponse recordCreateResponse = JsonConvert.DeserializeObject<RecordCreateResponse>(jsonData);
            obj.Id = recordCreateResponse.id;

            UnitTestDataManager.AddId(obj.Id.ToString());

            return obj;
        }

        public static void Update<T>(T obj) where T : SObject
        {
            var jsonData = JsonFactory.GetJsonForUpdate(obj);
            var objectName = typeof(T).Name;

            HttpManager httpManager = new HttpManager();
            httpManager.Patch($"sobjects/{objectName}/{obj.Id}", jsonData);
        }

        public static void Update<T>(IEnumerable<T> objects) where T : SObject
        {
            var objectName = typeof(T).Name;
            var httpManager = new HttpManager();

            foreach (var obj in objects)
            {
                var jsonData = JsonFactory.GetJsonForUpdate(obj);
                httpManager.Patch($"sobjects/{objectName}/{obj.Id}", jsonData);
            }
        }

        public static void Delete<T>(T obj) where T : SObject
        {
            var objectName = typeof(T).Name;
            Log.ForContext<SoqlApi>().Information("Deleting {$objectName} {$ID}", objectName, obj.Id);

            HttpManager httpManager = new HttpManager();
            httpManager.Del($"sobjects/{objectName}/{obj.Id}");
            UnitTestDataManager.RemoveId(obj.Id.ToString());
        }

        public static void Delete<T>(IEnumerable<T> objects) where T : SObject
        {
            var objectName = typeof(T).Name;
            var httpManager = new HttpManager();
            var logger = Log.ForContext<SoqlApi>();

            foreach (var obj in objects)
            {
                logger.Information("Deleting {$objectName} {$ID}", objectName, obj.Id);
                httpManager.Del($"sobjects/{objectName}/{obj.Id}");
                UnitTestDataManager.RemoveId(obj.Id.ToString());
            }
        }

        public static void Upsert<T>(T obj) where T : SObject
        {
            if (obj.Id is null)
            {
                Insert(obj);
            }
            else
            {
                Update(obj);
            }
        }

        public static void Upsert<T>(IEnumerable<T> objects) where T : SObject
        {
            foreach (var obj in objects)
            {
                Upsert(obj);
            }
        }
    }
}