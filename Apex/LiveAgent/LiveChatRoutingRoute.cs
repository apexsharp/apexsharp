namespace Apex.LiveAgent
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LiveChatRoutingRoute
    {
        // infrastructure
        public LiveChatRoutingRoute(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LiveChatRoutingRoute));
            }
        }

        // API
        public LiveChatRoutingRoute(string chatKey, string userId)
        {
            Self = Implementation.Constructor(chatKey, userId);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getChatKey()
        {
            return Self.getChatKey();
        }

        public string getUserId()
        {
            return Self.getUserId();
        }
    }
}
