namespace Apex.LiveAgent
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LiveChatRoutingRequest
    {
        // infrastructure
        public LiveChatRoutingRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LiveChatRoutingRequest));
            }
        }

        // API
        public LiveChatRoutingRequest(string chatKey, string liveChatButtonId, string liveChatTranscriptId)
        {
            Self = Implementation.Constructor(chatKey, liveChatButtonId, liveChatTranscriptId);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getChatKey()
        {
            return Self.getChatKey();
        }

        public string getLiveChatButtonId()
        {
            return Self.getLiveChatButtonId();
        }

        public string getLiveChatTranscriptId()
        {
            return Self.getLiveChatTranscriptId();
        }
    }
}
