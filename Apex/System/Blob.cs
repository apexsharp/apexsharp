namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_blob.htm#apex_methods_system_blob
    /// </summary>
    public class Blob
    {
        // infrastructure
        public Blob(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Blob));
            }
        }

        // API
        public int size()
        {
            return Self.size();
        }

        public static Blob toPdf(string stringToConvert)
        {
            return Implementation.toPdf(stringToConvert);
        }

        public string toString()
        {
            return Self.toString();
        }

        public static Blob valueOf(string stringToBlob)
        {
            return Implementation.valueOf(stringToBlob);
        }
    }
}
