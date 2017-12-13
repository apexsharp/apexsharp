namespace ApexSharpApi
{
    public class CompositeApi
    {
        private readonly ApexSharpConfig _connectionDetail;

        public CompositeApi(ApexSharpConfig connectionDetail)
        {
            _connectionDetail = connectionDetail;
        }
        //{


        //public async Task<CompositInsertReply> CreateRecords(RecordContainer recordContainer, string rootObject)
        //    HttpRequestMessage request = new HttpRequestMessage
        //    {
        //        RequestUri = new Uri(_connectionDetail.RestUrl + "/data/v36.0/composite/tree/" + rootObject + "/ "),
        //        Method = HttpMethod.Post
        //    };
        //    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    request.Headers.Add("Authorization", _connectionDetail.RestSessionId);

        //    JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        //    {
        //        NullValueHandling = NullValueHandling.Ignore,
        //    };
        //    serializerSettings.Converters.Add(new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ" });
        //    var requestJson = JsonConvert.SerializeObject(recordContainer, Formatting.Indented, serializerSettings);

        //    request.Content = new StringContent(requestJson, Encoding.UTF8, "application/json");

        //    HttpClient httpClient = new HttpClient();
        //    HttpResponseMessage responseMessage = await httpClient.SendAsync(request);


        //    // Console.WriteLine(responseMessage.StatusCode);
        //    switch (responseMessage.StatusCode)
        //    {
        //        case HttpStatusCode.Created:
        //            string jsonData = responseMessage.Content.ReadAsStringAsync().Result;
        //            Console.WriteLine(jsonData);
        //            CompositInsertReply compositInsertReply = JsonConvert.DeserializeObject<CompositInsertReply>(jsonData);
        //            return compositInsertReply;
        //        case HttpStatusCode.BadRequest:
        //            Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
        //            break;
        //        case HttpStatusCode.Unauthorized:
        //            Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
        //            break;
        //        default:
        //            Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
        //            break;
        //    }
        //    return null;
        //}
    }
}