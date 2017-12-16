namespace Apex.LiveAgent
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LiveChatRouter
    {
        // infrastructure
        public LiveChatRouter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LiveChatRouter));
            }
        }

        // API
        public void doRouting(List<LiveChatRoutingRequest> param1)
        {
            Self.doRouting(param1);
        }
    }
}
