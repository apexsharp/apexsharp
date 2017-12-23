namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class BinaryInput
    {
        // infrastructure
        public BinaryInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BinaryInput));
            }
        }

        // API
        public BinaryInput(Blob blobValue, string contentType, string filename)
        {
            Self = Implementation.Constructor(blobValue, contentType, filename);
        }

        public object clone()
        {
            return Self.clone();
        }

        public Blob getBlobValue()
        {
            return Self.getBlobValue();
        }

        public string getContentType()
        {
            return Self.getContentType();
        }

        public string getFilename()
        {
            return Self.getFilename();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
