namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmailMessageCapability
    {
        // infrastructure
        public EmailMessageCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailMessageCapability));
            }
        }

        // API
        object attachments
        {
            get
            {
                return Self.attachments;
            }
            set
            {
                Self.attachments = value;
            }
        }

        object bccAddresses
        {
            get
            {
                return Self.bccAddresses;
            }
            set
            {
                Self.bccAddresses = value;
            }
        }

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

        object ccAddresses
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

        object direction
        {
            get
            {
                return Self.direction;
            }
            set
            {
                Self.direction = value;
            }
        }

        object emailMessageId
        {
            get
            {
                return Self.emailMessageId;
            }
            set
            {
                Self.emailMessageId = value;
            }
        }

        object fromAddress
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

        object isRichText
        {
            get
            {
                return Self.isRichText;
            }
            set
            {
                Self.isRichText = value;
            }
        }

        object subject
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

        object textBody
        {
            get
            {
                return Self.textBody;
            }
            set
            {
                Self.textBody = value;
            }
        }

        object toAddresses
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

        object totalAttachments
        {
            get
            {
                return Self.totalAttachments;
            }
            set
            {
                Self.totalAttachments = value;
            }
        }

        public EmailMessageCapability()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
