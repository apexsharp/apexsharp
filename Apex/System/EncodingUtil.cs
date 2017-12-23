namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_restful_encodingUtil.htm#apex_classes_restful_encodingutil
    /// </summary>
    public class EncodingUtil
    {
        // infrastructure
        public EncodingUtil(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EncodingUtil));
            }
        }

        // API
        public static Blob base64Decode(string inputString)
        {
            return Implementation.base64Decode(inputString);
        }

        public static string base64Encode(Blob inputBlob)
        {
            return Implementation.base64Encode(inputBlob);
        }

        public static Blob convertFromHex(string inputString)
        {
            return Implementation.convertFromHex(inputString);
        }

        public static string convertToHex(Blob inputBlob)
        {
            return Implementation.convertToHex(inputBlob);
        }

        public static string urlDecode(string inputString, string encodingScheme)
        {
            return Implementation.urlDecode(inputString, encodingScheme);
        }

        public static string urlEncode(string inputString, string encodingScheme)
        {
            return Implementation.urlEncode(inputString, encodingScheme);
        }

        public EncodingUtil()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
