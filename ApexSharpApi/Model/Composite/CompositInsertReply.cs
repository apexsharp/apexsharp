namespace ApexSharpApi.Model.Composite
{
    public class CompositInsertReply
    {
        public bool hasErrors { get; set; }
        public Result[] results { get; set; }
    }

    public class Result
    {
        public string referenceId { get; set; }
        public string id { get; set; }
    }
}