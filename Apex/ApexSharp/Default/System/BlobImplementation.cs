using Apex.ApexSharp.Implementation;
using Apex.System;
using static System.Text.Encoding;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Blob))]
    public class BlobImplementation
    {
        // Self

        public class BlobInstance
        {
            internal byte[] BlobData { get; set; }

            public int size() => BlobData.Length;

            public string toString() =>
                BlobData == null ? null : UTF8.GetString(BlobData);
        }

        // Implementation

        public Blob toPdf(string o) => valueOf(o);

        public Blob valueOf(string o)
        {
            var bytes = o == null ? null : UTF8.GetBytes(o);
            var inst = new BlobInstance { BlobData = bytes };
            return new Blob(inst);
        }
    }
}
