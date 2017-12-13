using Apex.System;

namespace Apex.Social
{
    public class DefaultInboundSocialPostHandler
    {
        public object clone()
        {
            throw new global::System.NotImplementedException("DefaultInboundSocialPostHandler.Clone");
        }

        //public SObject CreatePersonaParent(SocialPersona persona){throw new global::System.NotImplementedException("DefaultInboundSocialPostHandler.CreatePersonaParent");}
        public string getDefaultAccountId()
        {
            throw new global::System.NotImplementedException("DefaultInboundSocialPostHandler.GetDefaultAccountId");
        }

        public int getMaxNumberOfDaysClosedToReopenCase()
        {
            throw new global::System.NotImplementedException(
                "DefaultInboundSocialPostHandler.GetMaxNumberOfDaysClosedToReopenCase");
        }

        //public string GetPersonaFirstName(SocialPersona persona){throw new global::System.NotImplementedException("DefaultInboundSocialPostHandler.GetPersonaFirstName");}
        //public string GetPersonaLastName(SocialPersona persona){throw new global::System.NotImplementedException("DefaultInboundSocialPostHandler.GetPersonaLastName");}
        public Set<String> getPostTagsThatCreateCase()
        {
            throw new global::System.NotImplementedException(
                "DefaultInboundSocialPostHandler.GetPostTagsThatCreateCase");
        }

        //public Social.InboundSocialPostResult HandleInboundSocialPost(SocialPost post,SocialPersona persona,Map<String,ANY> rawData){throw new global::System.NotImplementedException("DefaultInboundSocialPostHandler.HandleInboundSocialPost");}
    }
}