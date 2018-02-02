using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using ApexSharpApi.Model.RestApi;
using Newtonsoft.Json;
using Serilog;

namespace ApexSharpApi
{
    public class ConnectionUtil
    {
        public static ApexSharpConfig Session { get; set; }

        public static ApexSharpConfig GetSession(string configFileLocation)
        {
            if (configFileLocation == null)
            {
                if (Session == null)
                {
                    throw new ApexSharpNoConfigFoundException("No Session Exists Create One");
                }

                if (Session.SessionCreationDateTime <= DateTimeOffset.Now.ToUnixTimeSeconds())
                {
                    Log.ForContext<ConnectionUtil>().Information("Session Expired, Creating a New Session");
                    Session = CreateSession(Session);
                }
                return Session;
            }

            FileInfo loadFileInfo = new FileInfo(configFileLocation);
            if (loadFileInfo.Exists)
            {
                string json = File.ReadAllText(loadFileInfo.FullName);
                Session = JsonConvert.DeserializeObject<ApexSharpConfig>(json);

                if (Session.SessionCreationDateTime <= DateTimeOffset.Now.ToUnixTimeSeconds())
                {
                    Log.ForContext<ConnectionUtil>().Information("Session Expired, Creating a New Session");
                    Session = CreateSession(Session);
                    return Session;
                }

                Log.ForContext<ConnectionUtil>().Information("Found Session On {configFileLocation}", configFileLocation);
                return Session;
            }
            throw new ApexSharpNoConfigFoundException(loadFileInfo.FullName);
        }

        public static ApexSharpConfig CreateSession(ApexSharpConfig config)
        {
            config.SalesForceSoapUrl = config.SalesForceSoapUrl + "services/Soap/c/" + config.SalesForceApiVersion + ".0/";
            config = GetNewConnection(config);

            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            Directory.CreateDirectory(Path.GetDirectoryName(config.ConfigLocation));
            File.WriteAllText(config.ConfigLocation, json);

            return config;
        }

        private static ApexSharpConfig GetNewConnection(ApexSharpConfig config)
        {
            var xml = @"
                <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:urn=""urn:enterprise.soap.sforce.com"">
                    <soapenv:Header>
                        <urn:LoginScopeHeader>
                        <urn:organizationId></urn:organizationId>
                        <urn:portalId></urn:portalId>
                        </urn:LoginScopeHeader>
                    </soapenv:Header>
                    <soapenv:Body>
                        <urn:login>
                            <urn:username>" + config.SalesForceUserId + "</urn:username>" +
                            "<urn:password>" + config.SalesForcePassword + config.SalesForcePasswordToken + "</urn:password>" +
                        "</urn:login>" +
                    "</soapenv:Body>" +
                "</soapenv:Envelope>";


            var returnXml = PostLoginTask(config.SalesForceSoapUrl, xml);
            if (returnXml.Contains("INVALID_LOGIN"))
            {
                throw new SalesForceInvalidLoginException("Invalid Login");
            }
            else if (returnXml.Contains("API_DISABLED_FOR_ORG"))
            {
                throw new SalesForceInvalidLoginException("Webservice API is disabled for this login or organization.");
            }

            try
            {
                Envelope envelope = UtilXml.DeSerilizeFromXML<Envelope>(returnXml);


                var soapIndex =
                    envelope.Body.loginResponse.result.serverUrl.IndexOf(@"/Soap", StringComparison.Ordinal);
                var restUrl = envelope.Body.loginResponse.result.serverUrl.Substring(0, soapIndex);
                var restSessionId = "Bearer " + envelope.Body.loginResponse.result.sessionId;


                config.SalesForceSoapUrl = envelope.Body.loginResponse.result.serverUrl;
                config.RestUrl = restUrl;
                config.RestSessionId = restSessionId;
                config.SessionCreationDateTime = DateTimeOffset.Now.ToUnixTimeSeconds() +
                                                 envelope.Body.loginResponse.result.userInfo.sessionSecondsValid;

                return config;
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Fix the error and restart " + e);
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            return null;
        }

        private static string PostLoginTask(string url, string json)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Post,
                Content = new StringContent(json, Encoding.UTF8, "text/xml"),
            };
            request.Headers.Add("SOAPAction", "''");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = httpClient.SendAsync(request).Result;

            string xml = responseMessage.Content.ReadAsStringAsync().Result;
            switch (responseMessage.StatusCode)
            {
                case HttpStatusCode.OK:
                    Log.ForContext<ConnectionUtil>().Information("Login Success {xml}", xml);
                    return xml;
                default:
                    Log.ForContext<ConnectionUtil>().Error("Login Fail {xml}", xml);
                    return xml;
            }
        }
    }
}