using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Linq;
using Serilog;

namespace ApexSharpApi
{
    public class HttpManager
    {
        public string Get(string uriFunction)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(ApexSharp.GetSession().RestUrl + "/data/v" +
                                     ApexSharp.GetSession().SalesForceApiVersion + ".0/" + uriFunction),
                Method = HttpMethod.Get,
            };
            return Http(request);
        }


        public string Post(string uriFunction, string json)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(ApexSharp.GetSession().RestUrl + "/data/v" +
                                     ApexSharp.GetSession().SalesForceApiVersion + ".0/" + uriFunction),
                Method = HttpMethod.Post,
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            try
            {
                return Http(request);
            }
            catch (ApexSharpHttpException ex)
            {
                return ex.Message;
            }
        }

        public string Patch(string uriFunction, string json)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(ApexSharp.GetSession().RestUrl + "/data/v" +
                                     ApexSharp.GetSession().SalesForceApiVersion + ".0/" + uriFunction),
                Method = new HttpMethod("PATCH"),
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            return Http(request);
        }

        public string Del(string uriFunction)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(ApexSharp.GetSession().RestUrl + "/data/v" +
                                     ApexSharp.GetSession().SalesForceApiVersion + ".0/" + uriFunction),
                Method = HttpMethod.Delete,
            };
            return Http(request);
        }



        private string Http(HttpRequestMessage request)
        {
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("Authorization", ApexSharp.GetSession().RestSessionId);

            //WebProxy proxy = new WebProxy { Address = new Uri("") };
            //HttpClientHandler httpClientHandler = new HttpClientHandler()
            //{
            //    Proxy = proxy,
            //    PreAuthenticate = true,
            //    UseDefaultCredentials = false,
            //};
            //HttpClient httpClient = new HttpClient(httpClientHandler);


            HttpClient httpClient = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Log.ForContext<HttpManager>().Verbose("Outgoing Request {@request}", request);
            HttpResponseMessage responseMessage = httpClient.SendAsync(request).Result;
            Log.ForContext<HttpManager>().Verbose("Incoming Response {@responseMessage}", responseMessage);

            string jsonData = responseMessage.Content.ReadAsStringAsync().Result;

            // The following code fails to parse an empty JSON response:
            //JToken jt = JToken.Parse(jsonData);
            //string formattedJson = jt.ToString();
            //Log.ForContext<HttpManager>().Verbose(formattedJson);

            switch (responseMessage.StatusCode)
            {
                case HttpStatusCode.NoContent:
                case HttpStatusCode.Created:
                case HttpStatusCode.OK:
                    return jsonData;
                default:
                    Log.ForContext<HttpManager>().Error(jsonData);
                    return jsonData;
            }
        }
    }
}