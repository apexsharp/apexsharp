namespace Apex.Social
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InboundSocialPostHandler
    {
        // infrastructure
        public InboundSocialPostHandler(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InboundSocialPostHandler));
            }
        }

        // API
        public InboundSocialPostResult handleInboundSocialPost(SocialPost param1, SocialPersona param2, Map<string, object> param3)
        {
            return Self.handleInboundSocialPost(param1, param2, param3);
        }
    }
}
