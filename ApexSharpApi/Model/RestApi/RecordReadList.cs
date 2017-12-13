using System.Collections.Generic;

namespace ApexSharpApi.Model.RestApi
{
    public class RecordReadList<T>
    {
        public int totalSize { get; set; }
        public bool done { get; set; }
        public string nextRecordsUrl { get; set; }
        public List<T> records { get; set; }
    }
}