namespace Apex.LiveAgent
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LiveChatRoutingResult
    {
        // infrastructure
        public LiveChatRoutingResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LiveChatRoutingResult));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getChatKey()
        {
            return Self.getChatKey();
        }

        public LiveChatRoutingResultType getResult()
        {
            return Self.getResult();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
        }
    }
}
