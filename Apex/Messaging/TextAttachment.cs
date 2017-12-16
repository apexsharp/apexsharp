namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TextAttachment
    {
        // infrastructure
        public TextAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TextAttachment));
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

        object bodyIsTruncated
        {
            get
            {
                return Self.bodyIsTruncated;
            }
            set
            {
                Self.bodyIsTruncated = value;
            }
        }

        object charset
        {
            get
            {
                return Self.charset;
            }
            set
            {
                Self.charset = value;
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

        public TextAttachment()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
