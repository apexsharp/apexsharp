using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Serilog;

namespace ApexSharpApi
{
    public class HttpManager
    {
        public string Get(string uriFunction)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(ConnectionUtil.GetSession().RestUrl + "/data/v" +
                                     ConnectionUtil.GetSession().SalesForceApiVersion + ".0/" + uriFunction),
                Method = HttpMethod.Get,
            };
            return Http(request);
        }


        public string Post(string uriFunction, string json)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(ConnectionUtil.GetSession().RestUrl + "/data/v" +
                                     ConnectionUtil.GetSession().SalesForceApiVersion + ".0/" + uriFunction),
                Method = HttpMethod.Post,
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            return Http(request);
        }

        public string Patch(string uriFunction, string json)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(ConnectionUtil.GetSession().RestUrl + "/data/v" +
                                     ConnectionUtil.GetSession().SalesForceApiVersion + ".0/" + uriFunction),
                Method = new HttpMethod("PATCH"),
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            return Http(request);
        }

        public string Del(string uriFunction)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(ConnectionUtil.GetSession().RestUrl + "/data/v" +
                         ConnectionUtil.GetSession().SalesForceApiVersion + ".0/" + uriFunction),
                Method = HttpMethod.Delete,
            };
            return Http(request);
        }



        private string Http(HttpRequestMessage request)
        {
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("Authorization", ConnectionUtil.GetSession().RestSessionId);

            //WebProxy proxy = new WebProxy { Address = new Uri("http://naproxy.gm.com:80") };

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
            Log.ForContext<HttpManager>().Verbose("Incoming Data {@jsonData}", jsonData);

            switch (responseMessage.StatusCode)
            {
                case HttpStatusCode.NoContent:
                case HttpStatusCode.Created:
                case HttpStatusCode.OK:
                    return jsonData;
                default:
                    var exp = new ApexSharpHttpException(Environment.StackTrace);
                    Log.ForContext<HttpManager>().Error(exp, jsonData);
                    throw exp;
            }
        }
    }
}