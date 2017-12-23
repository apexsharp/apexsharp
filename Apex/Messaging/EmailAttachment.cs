namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmailAttachment
    {
        // infrastructure
        public EmailAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailAttachment));
            }
        }

        // API
        Blob body
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

        string contentId
        {
            get
            {
                return Self.contentId;
            }
            set
            {
                Self.contentId = value;
            }
        }

        string contentType
        {
            get
            {
                return Self.contentType;
            }
            set
            {
                Self.contentType = value;
            }
        }

        string fileName
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

        public EmailAttachment()
        {
            Self = Implementation.Constructor();
        }

        public Blob getBody()
        {
            return Self.getBody();
        }

        public string getContentId()
        {
            return Self.getContentId();
        }

        public string getContentType()
        {
            return Self.getContentType();
        }

        public string getFileName()
        {
            return Self.getFileName();
        }

        public void setBody(Blob param1)
        {
            Self.setBody(param1);
        }

        public void setContentId(string param1)
        {
            Self.setContentId(param1);
        }

        public void setContentType(string param1)
        {
            Self.setContentType(param1);
        }

        public void setFileName(string param1)
        {
            Self.setFileName(param1);
        }
    }
}
