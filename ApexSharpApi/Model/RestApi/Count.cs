namespace ApexSharpApi.Model.RestApi
{
    public class Count
    {
        public int totalSize { get; set; }
        public bool done { get; set; }
        public Record[] records { get; set; }
    }

    public class Record
    {
        public Attributes attributes { get; set; }
        public int expr0 { get; set; }
    }

    public class Attributes
    {
        public string type { get; set; }
    }
}