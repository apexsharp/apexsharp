namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChatterMessage
    {
        // infrastructure
        public ChatterMessage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterMessage));
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

        object conversationId
        {
            get
            {
                return Self.conversationId;
            }
            set
            {
                Self.conversationId = value;
            }
        }

        object conversationUrl
        {
            get
            {
                return Self.conversationUrl;
            }
            set
            {
                Self.conversationUrl = value;
            }
        }

        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

        object recipients
        {
            get
            {
                return Self.recipients;
            }
            set
            {
                Self.recipients = value;
            }
        }

        object sender
        {
            get
            {
                return Self.sender;
            }
            set
            {
                Self.sender = value;
            }
        }

        object sendingCommunity
        {
            get
            {
                return Self.sendingCommunity;
            }
            set
            {
                Self.sendingCommunity = value;
            }
        }

        object sentDate
        {
            get
            {
                return Self.sentDate;
            }
            set
            {
                Self.sentDate = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        public ChatterMessage()
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
