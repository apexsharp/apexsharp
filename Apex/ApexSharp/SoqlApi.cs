using System;
using System.Collections.Generic;
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
        public static SoqlQuery<T> Query<T>() where T : SObject
        {
            // prepare query text
            var soqlCreator = new SoqlCreator();
            var soql = soqlCreator.GetSoql<T>();

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
            var jsonData = JsonFactory.GetJson(obj);

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
            var jsonData = JsonFactory.GetJsonUpdate(obj);
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
                var jsonData = JsonFactory.GetJsonUpdate(obj);
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