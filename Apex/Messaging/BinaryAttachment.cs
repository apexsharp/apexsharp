namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class BinaryAttachment
    {
        // infrastructure
        public BinaryAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BinaryAttachment));
            }
        }

        // API
        object body
        {
            get
            {
                return Self.body;
            }
            set
            {
                Self.body = value;
            }
        }

        object fileName
        {
            get
            {
                return Self.fileName;
            }
            set
            {
                Self.fileName = value;
            }
        }

        object headers
        {
            get
            {
                return Self.headers;
            }
            set
            {
                Self.headers = value;
            }
        }

        object mimeTypeSubType
        {
            get
            {
                return Self.mimeTypeSubType;
            }
            set
            {
                Self.mimeTypeSubType = value;
            }
        }

        public BinaryAttachment()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
