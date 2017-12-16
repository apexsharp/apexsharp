namespace Apex.Social
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InboundSocialPostHandlerImpl
    {
        // infrastructure
        public InboundSocialPostHandlerImpl(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InboundSocialPostHandlerImpl));
            }
        }

        // API
        public InboundSocialPostHandlerImpl()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public SObject createPersonaParent(SocialPersona persona)
        {
            return Self.createPersonaParent(persona);
        }

        public string getCaseSubject(SocialPost post)
        {
            return Self.getCaseSubject(post);
        }

        public string getDefaultAccountId()
        {
            return Self.getDefaultAccountId();
        }

        public int getMaxNumberOfDaysClosedToReopenCase()
        {
            return Self.getMaxNumberOfDaysClosedToReopenCase();
        }

        public string getPersonaFirstName(SocialPersona persona)
        {
            return Self.getPersonaFirstName(persona);
        }

        public string getPersonaLastName(SocialPersona persona)
        {
            return Self.getPersonaLastName(persona);
        }

        public Set<string> getPostTagsThatCreateCase()
        {
            return Self.getPostTagsThatCreateCase();
        }

        public InboundSocialPostResult handleInboundSocialPost(SocialPost post, SocialPersona persona, Map<string, object> rawData)
        {
            return Self.handleInboundSocialPost(post, persona, rawData);
        }
    }
}
