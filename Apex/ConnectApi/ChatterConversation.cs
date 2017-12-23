namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChatterConversation
    {
        // infrastructure
        public ChatterConversation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterConversation));
            }
        }

        // API
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

        object members
        {
            get
            {
                return Self.members;
            }
            set
            {
                Self.members = value;
            }
        }

        object messages
        {
            get
            {
                return Self.messages;
            }
            set
            {
                Self.messages = value;
            }
        }

        object read
        {
            get
            {
                return Self.read;
            }
            set
            {
                Self.read = value;
            }
        }

        public ChatterConversation()
        {
            Self = Implementation.Constructor();
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
