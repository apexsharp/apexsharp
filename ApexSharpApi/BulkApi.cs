using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ApexSharpApi.Attribute;
using ApexSharpApi.Model.BulkApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApexSharpApi
{
    public class BulkApi
    {
        private readonly ApexSharpConfig _connectionDetail;

        public BulkApi()
        {
            _connectionDetail = ConnectionUtil.GetSession();
        }

        // ToDo : Remove All this duplicate code
        public string GetSalesForceObjectName<T>()
        {
            string objectName = typeof(T).Name;
            ObjectNameAttribute objectNameAttrbute = typeof(T).GetCustomAttributes(typeof(ObjectNameAttribute), true)
                .FirstOrDefault() as ObjectNameAttribute;
            if (objectNameAttrbute != null)
            {
                objectName = objectNameAttrbute.SalesForceObjectName;
            }
            return objectName;
        }


        public string BulkRequest<T>(int checkIntervel)
        {


            SoqlCreator soql = new SoqlCreator();
            string query = soql.GetSoql<T>();

            var objectName = GetSalesForceObjectName<T>();

            var url = "/async/36.0/job/";
            var jobInfo = new JobInfoRequest
            {
                operation = "query",
                @object = objectName,
                concurrencyMode = "Parallel",
                contentType = "JSON",
            };
            var xml = UtilXml.SerializeToXML(jobInfo);

            var waitTask = Post(url, xml, "application/xml");
            waitTask.Wait();

            var jobInfoReply = UtilXml.DeSerilizeFromXML<JobInfoReply>(waitTask.Result);

            waitTask = Post(url + jobInfoReply.id + "/batch", query, "application/json");
            waitTask.Wait();

            var batchJobReply = JsonConvert.DeserializeObject<BatchJobReply>(waitTask.Result);

            while (batchJobReply.state != "Completed")
            {
                waitTask = Get(url + jobInfoReply.id + "/batch/" + batchJobReply.id);
                waitTask.Wait();
                var json = waitTask.Result;
                batchJobReply = JsonConvert.DeserializeObject<BatchJobReply>(json,
                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                if (batchJobReply.state != "Completed")
                {
                    Console.WriteLine($"Job {batchJobReply.state}, Waiting for {checkIntervel} miliseconds");
                    Thread.Sleep(checkIntervel);
                }
            }


            waitTask = Get(url + jobInfoReply.id + "/batch/" + batchJobReply.id + "/result");
            waitTask.Wait();

            var resultLength = waitTask.Result.Length;
            var result = waitTask.Result.Substring(2, resultLength - 4);

            waitTask = Get(url + jobInfoReply.id + "/batch/" + batchJobReply.id + "/result/" + result);
            waitTask.Wait();

            return waitTask.Result;
        }

        public async Task<BulkInsertReply> CreateRecordBulk<T>(BulkInsertRequest<T> bulkInsertrequest)
        {
            var objectName = GetSalesForceObjectName<T>();
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(_connectionDetail.RestUrl + "/data/v37.0/composite/tree/" + objectName),
                Method = HttpMethod.Post,
            };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("Authorization", _connectionDetail.RestSessionId);

            string requestJson = GetJsonBulkInsert<T>(bulkInsertrequest);

            Console.WriteLine(requestJson);

            request.Content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.SendAsync(request);


            //   Console.WriteLine(responseMessage.StatusCode);
            switch (responseMessage.StatusCode)
            {
                case HttpStatusCode.Created:
                    string jsonData = responseMessage.Content.ReadAsStringAsync().Result;
                    //         Console.WriteLine(jsonData);
                    BulkInsertReply bulkInsertReply = JsonConvert.DeserializeObject<BulkInsertReply>(jsonData);
                    return bulkInsertReply;
                case HttpStatusCode.BadRequest:
                    Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
                    break;
                case HttpStatusCode.Unauthorized:
                    Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
                    break;
                default:
                    Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
                    break;
            }
            return null;
        }

        public string GetJsonBulkInsert<T>(BulkInsertRequest<T> request)
        {
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            };

            //serializerSettings.Converters.Add(new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ" });


            foreach (T record in request.Records)
            {
                T recordToInsert = (T)record;


                //recordToInsert.CreatedById = null;
                //recordToInsert.CreatedDate = null;
                //recordToInsert.LastModifiedById = null;
                //recordToInsert.LastModifiedDate = null;
                //recordToInsert.LastViewedDate = null;
                //recordToInsert.SystemModstamp = null;
                //recordToInsert.LastReferencedDate = null;
            }


            string requestJson = JsonConvert.SerializeObject(request, Formatting.Indented, serializerSettings);


            // Create JSON Line https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/requests_composite_sobject_tree.htm#topic-title
            JObject obj = JObject.Parse(requestJson);
            JArray reccords = (JArray)obj["records"];

            foreach (var reccord in reccords)
            {
                var recordObject = (JObject)reccord;
                Console.WriteLine(recordObject["ID"]);

                Attributes attribute =
                    new Attributes
                    {
                        type = typeof(T).Name,
                        referenceId = recordObject["ID"].ToString(),
                    };
                var attributeObject = JObject.FromObject(attribute);
                recordObject.Add(new JProperty("attributes", attributeObject));

                recordObject.Remove("ID");
            }


            return obj.ToString(Formatting.Indented);
        }

        public async Task<string> Post(string url, string json, string dataType)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(_connectionDetail.RestUrl + url),
                Method = HttpMethod.Post,
            };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("X-SFDC-Session", _connectionDetail.SessionId);

            Console.WriteLine(UtilXml.FormatXml(json));
            request.Content = new StringContent(json, Encoding.UTF8, dataType);

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.SendAsync(request);

            switch (responseMessage.StatusCode)
            {
                case HttpStatusCode.Created:
                    string jsonData = responseMessage.Content.ReadAsStringAsync().Result;
                    return jsonData;
                case HttpStatusCode.BadRequest:
                    Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
                    break;
                case HttpStatusCode.Unauthorized:
                    Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
                    break;
                default:
                    Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
                    break;
            }
            return null;
        }

        public async Task<string> Get(string url)
        {
            Console.WriteLine(url);
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(_connectionDetail.RestUrl + url),
                Method = HttpMethod.Get,
            };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("X-SFDC-Session", _connectionDetail.SessionId);

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.SendAsync(request);

            switch (responseMessage.StatusCode)
            {
                case HttpStatusCode.OK:
                case HttpStatusCode.Created:
                    string jsonData = responseMessage.Content.ReadAsStringAsync().Result;
                    return jsonData;
                case HttpStatusCode.BadRequest:
                    Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
                    break;
                case HttpStatusCode.Unauthorized:
                    Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
                    break;
                default:
                    Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
                    break;
            }
            return null;
        }
    }
}