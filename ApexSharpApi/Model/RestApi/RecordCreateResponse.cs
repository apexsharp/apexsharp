namespace ApexSharpApi.Model.RestApi
{
    public class RecordCreateResponse
    {
        public string id { get; set; }
        public bool success { get; set; }
        public object[] errors { get; set; }
    }
}