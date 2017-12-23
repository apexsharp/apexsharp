namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_email_inbound_inbound.htm#apex_classes_email_inbound_inbound
    /// </summary>
    public class InboundEmail
    {
        // infrastructure
        public InboundEmail(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InboundEmail));
            }
        }

        // API
        public InboundEmail()
        {
            Self = Implementation.Constructor();
        }

        BinaryAttachment[] binaryAttachments
        {
            get
            {
                return Self.binaryAttachments;
            }
            set
            {
                Self.binaryAttachments = value;
            }
        }

        string[] ccAddresses
        {
            get
            {
                return Self.ccAddresses;
            }
            set
            {
                Self.ccAddresses = value;
            }
        }

        string fromAddress
        {
            get
            {
                return Self.fromAddress;
            }
            set
            {
                Self.fromAddress = value;
            }
        }

        string fromName
        {
            get
            {
                return Self.fromName;
            }
            set
            {
                Self.fromName = value;
            }
        }

        Header[] headers
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

        string htmlBody
        {
            get
            {
                return Self.htmlBody;
            }
            set
            {
                Self.htmlBody = value;
            }
        }

        bool htmlBodyIsTruncated
        {
            get
            {
                return Self.htmlBodyIsTruncated;
            }
            set
            {
                Self.htmlBodyIsTruncated = value;
            }
        }

        string inReplyTo
        {
            get
            {
                return Self.inReplyTo;
            }
            set
            {
                Self.inReplyTo = value;
            }
        }

        string messageId
        {
            get
            {
                return Self.messageId;
            }
            set
            {
                Self.messageId = value;
            }
        }

        string plainTextBody
        {
            get
            {
                return Self.plainTextBody;
            }
            set
            {
                Self.plainTextBody = value;
            }
        }

        bool plainTextBodyIsTruncated
        {
            get
            {
                return Self.plainTextBodyIsTruncated;
            }
            set
            {
                Self.plainTextBodyIsTruncated = value;
            }
        }

        string[] references
        {
            get
            {
                return Self.references;
            }
            set
            {
                Self.references = value;
            }
        }

        string replyTo
        {
            get
            {
                return Self.replyTo;
            }
            set
            {
                Self.replyTo = value;
            }
        }

        string subject
        {
            get
            {
                return Self.subject;
            }
            set
            {
                Self.subject = value;
            }
        }

        TextAttachment[] textAttachments
        {
            get
            {
                return Self.textAttachments;
            }
            set
            {
                Self.textAttachments = value;
            }
        }

        string[] toAddresses
        {
            get
            {
                return Self.toAddresses;
            }
            set
            {
                Self.toAddresses = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
