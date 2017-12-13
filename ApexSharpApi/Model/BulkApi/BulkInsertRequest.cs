using Newtonsoft.Json;

namespace ApexSharpApi.Model.BulkApi
{
    public class BulkInsertRequest<T>
    {
        [JsonProperty(PropertyName = "records")]
        public T[] Records { get; set; }
    }

    public class BulkInsertRequest
    {
        //  [JsonProperty(PropertyName = "records")]
        //  public BaseObject[] Records { get; set; }
    }

    public class BulkAttributes
    {
        public string type { get; set; }
        public string referenceId { get; set; }
    }


    public class BulkInsertReply
    {
        public bool hasErrors { get; set; }

        [JsonProperty(PropertyName = "results")]
        public BulkInsert[] results { get; set; }
    }

    public class BulkInsert
    {
        public string referenceId { get; set; }
        public string id { get; set; }
        public Error[] errors { get; set; }
    }


    public class Error
    {
        public string statusCode { get; set; }
        public string message { get; set; }
        public object[] fields { get; set; }
    }
}