namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_email_outbound_attachment.htm#apex_classes_email_outbound_attachment
    /// </summary>
    public class EmailFileAttachment
    {
        // infrastructure
        public EmailFileAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailFileAttachment));
            }
        }

        // API
        public EmailFileAttachment()
        {
            Self = Implementation.Constructor();
        }

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

        string contenttype
        {
            get
            {
                return Self.contenttype;
            }
            set
            {
                Self.contenttype = value;
            }
        }

        string filename
        {
            get
            {
                return Self.filename;
            }
            set
            {
                Self.filename = value;
            }
        }

        ID id
        {
            get
            {
                return Self.id;
            }
        }

        bool inline
        {
            get
            {
                return Self.inline;
            }
            set
            {
                Self.inline = value;
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

        public Blob getBody()
        {
            return Self.getBody();
        }

        public string getContentType()
        {
            return Self.getContentType();
        }

        public string getFileName()
        {
            return Self.getFileName();
        }

        public ID getId()
        {
            return Self.getId();
        }

        public bool getInline()
        {
            return Self.getInline();
        }

        public void setBody(Blob param1)
        {
            Self.setBody(param1);
        }

        public void setContentType(string param1)
        {
            Self.setContentType(param1);
        }

        public void setFileName(string param1)
        {
            Self.setFileName(param1);
        }

        public void setInline(bool param1)
        {
            Self.setInline(param1);
        }
    }
}
