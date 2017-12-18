namespace Apex.LiveAgent
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LiveAgentRealTimeSystem
    {
        // infrastructure
        public LiveAgentRealTimeSystem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LiveAgentRealTimeSystem));
            }
        }

        // API
        public LiveAgentRealTimeSystem()
        {
            Self = Implementation.Constructor();
        }

        public static void cancelChatRequests(List<string> requests)
        {
            Implementation.cancelChatRequests(requests);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static List<LiveChatRoutingResult> routeChatRequests(List<LiveChatRoutingRoute> routes)
        {
            return Implementation.routeChatRequests(routes);
        }

        public static void setButtonStatus(string liveChatButtonId, bool online)
        {
            Implementation.setButtonStatus(liveChatButtonId, online);
        }
    }
}
