namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UnreadConversationCount
    {
        // infrastructure
        public UnreadConversationCount(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UnreadConversationCount));
            }
        }

        // API
        object hasMore
        {
            get
            {
                return Self.hasMore;
            }
            set
            {
                Self.hasMore = value;
            }
        }

        object unreadCount
        {
            get
            {
                return Self.unreadCount;
            }
            set
            {
                Self.unreadCount = value;
            }
        }

        public UnreadConversationCount()
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
