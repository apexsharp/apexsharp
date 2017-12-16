namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmailMessage
    {
        // infrastructure
        public EmailMessage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailMessage));
            }
        }

        // API
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

        public EmailMessage()
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
