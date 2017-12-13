namespace Apex.ConnectApi
{
    public class Recommendations
    {
        public object clone()
        {
            throw new global::System.NotImplementedException("Recommendations.Clone");
        }

        public static RecommendationAudience createRecommendationAudience(string communityId,
            RecommendationAudienceInput recommendationAudience)
        {
            throw new global::System.NotImplementedException("Recommendations.CreateRecommendationAudience");
        }

        public static RecommendationAudience createRecommendationAudience(string communityId, string name)
        {
            throw new global::System.NotImplementedException("Recommendations.CreateRecommendationAudience");
        }

        public static RecommendationDefinition createRecommendationDefinition(string communityId,
            RecommendationDefinitionInput recommendationDefinition)
        {
            throw new global::System.NotImplementedException("Recommendations.CreateRecommendationDefinition");
        }

        public static RecommendationDefinition createRecommendationDefinition(string communityId, string name,
            string title, string actionUrl, string actionUrlName, string explanation)
        {
            throw new global::System.NotImplementedException("Recommendations.CreateRecommendationDefinition");
        }

        public static ScheduledRecommendation createScheduledRecommendation(string communityId,
            ScheduledRecommendationInput scheduledRecommendation)
        {
            throw new global::System.NotImplementedException("Recommendations.CreateScheduledRecommendation");
        }

        public static ScheduledRecommendation createScheduledRecommendation(string communityId,
            string recommendationDefinitionId, int rank, bool enabled, string recommendationAudienceId)
        {
            throw new global::System.NotImplementedException("Recommendations.CreateScheduledRecommendation");
        }

        public static ScheduledRecommendation createScheduledRecommendation(string communityId,
            string recommendationDefinitionId, int rank, bool enabled, string recommendationAudienceId,
            RecommendationChannel channel)
        {
            throw new global::System.NotImplementedException("Recommendations.CreateScheduledRecommendation");
        }

        public static void deleteRecommendationAudience(string communityId, string recommendationAudienceId)
        {
            throw new global::System.NotImplementedException("Recommendations.DeleteRecommendationAudience");
        }

        public static void deleteRecommendationDefinition(string communityId, string recommendationDefinitionId)
        {
            throw new global::System.NotImplementedException("Recommendations.DeleteRecommendationDefinition");
        }

        public static void deleteRecommendationDefinitionPhoto(string communityId, string recommendationDefinitionId)
        {
            throw new global::System.NotImplementedException("Recommendations.DeleteRecommendationDefinitionPhoto");
        }

        public static void deleteScheduledRecommendation(string communityId, string scheduledRecommendationId,
            bool deleteDefinitionIfLast)
        {
            throw new global::System.NotImplementedException("Recommendations.DeleteScheduledRecommendation");
        }

        public static RecommendationAudience getRecommendationAudience(string communityId,
            string recommendationAudienceId)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationAudience");
        }

        public static UserReferencePage getRecommendationAudienceMembership(string communityId,
            string recommendationAudienceId)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationAudienceMembership");
        }

        public static UserReferencePage getRecommendationAudienceMembership(string communityId,
            string recommendationAudienceId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationAudienceMembership");
        }

        public static RecommendationAudiencePage getRecommendationAudiences(string communityId)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationAudiences");
        }

        public static RecommendationAudiencePage getRecommendationAudiences(string communityId, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationAudiences");
        }

        public static RecommendationDefinition getRecommendationDefinition(string communityId,
            string recommendationDefinitionId)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationDefinition");
        }

        public static Photo getRecommendationDefinitionPhoto(string communityId, string recommendationDefinitionId)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationDefinitionPhoto");
        }

        public static RecommendationDefinitionPage getRecommendationDefinitions(string communityId)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationDefinitions");
        }

        public static RecommendationCollection getRecommendationForUser(string communityId, string userId,
            RecommendationActionType action, string objectId)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationForUser");
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId,
            RecommendationActionType action, RecommendationActionType contextAction, string contextObjectId,
            RecommendationChannel channel, int maxResults)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationsForUser");
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId,
            RecommendationActionType action, RecommendationActionType contextAction, string contextObjectId,
            int maxResults)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationsForUser");
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId,
            RecommendationActionType action, string objectCategory, RecommendationActionType contextAction,
            string contextObjectId, RecommendationChannel channel, int maxResults)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationsForUser");
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId,
            RecommendationActionType action, string objectCategory, RecommendationActionType contextAction,
            string contextObjectId, int maxResults)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationsForUser");
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId,
            RecommendationActionType contextAction, string contextObjectId, RecommendationChannel channel,
            int maxResults)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationsForUser");
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId,
            RecommendationActionType contextAction, string contextObjectId, int maxResults)
        {
            throw new global::System.NotImplementedException("Recommendations.GetRecommendationsForUser");
        }

        public static ScheduledRecommendation getScheduledRecommendation(string communityId,
            string scheduledRecommendationId)
        {
            throw new global::System.NotImplementedException("Recommendations.GetScheduledRecommendation");
        }

        public static ScheduledRecommendationPage getScheduledRecommendations(string communityId)
        {
            throw new global::System.NotImplementedException("Recommendations.GetScheduledRecommendations");
        }

        public static ScheduledRecommendationPage getScheduledRecommendations(string communityId,
            RecommendationChannel channel)
        {
            throw new global::System.NotImplementedException("Recommendations.GetScheduledRecommendations");
        }

        public static void rejectRecommendationForUser(string communityId, string userId,
            RecommendationActionType action, RecommendedObjectType objectEnum)
        {
            throw new global::System.NotImplementedException("Recommendations.RejectRecommendationForUser");
        }

        public static void rejectRecommendationForUser(string communityId, string userId,
            RecommendationActionType action, string objectId)
        {
            throw new global::System.NotImplementedException("Recommendations.RejectRecommendationForUser");
        }

        public static void setTestGetRecommendationForUser(string communityId, string userId,
            RecommendationActionType action, string objectId, RecommendationCollection result)
        {
            throw new global::System.NotImplementedException("Recommendations.SetTestGetRecommendationForUser");
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId,
            RecommendationActionType action, RecommendationActionType contextAction, string contextObjectId,
            RecommendationChannel channel, int maxResults, RecommendationCollection result)
        {
            throw new global::System.NotImplementedException("Recommendations.SetTestGetRecommendationsForUser");
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId,
            RecommendationActionType action, RecommendationActionType contextAction, string contextObjectId,
            int maxResults, RecommendationCollection result)
        {
            throw new global::System.NotImplementedException("Recommendations.SetTestGetRecommendationsForUser");
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId,
            RecommendationActionType action, string objectCategory, RecommendationActionType contextAction,
            string contextObjectId, RecommendationChannel channel, int maxResults, RecommendationCollection result)
        {
            throw new global::System.NotImplementedException("Recommendations.SetTestGetRecommendationsForUser");
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId,
            RecommendationActionType action, string objectCategory, RecommendationActionType contextAction,
            string contextObjectId, int maxResults, RecommendationCollection result)
        {
            throw new global::System.NotImplementedException("Recommendations.SetTestGetRecommendationsForUser");
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId,
            RecommendationActionType contextAction, string contextObjectId, RecommendationChannel channel,
            int maxResults, RecommendationCollection result)
        {
            throw new global::System.NotImplementedException("Recommendations.SetTestGetRecommendationsForUser");
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId,
            RecommendationActionType contextAction, string contextObjectId, int maxResults,
            RecommendationCollection result)
        {
            throw new global::System.NotImplementedException("Recommendations.SetTestGetRecommendationsForUser");
        }

        public static RecommendationAudience updateRecommendationAudience(string communityId,
            string recommendationAudienceId, RecommendationAudienceInput recommendationAudience)
        {
            throw new global::System.NotImplementedException("Recommendations.UpdateRecommendationAudience");
        }

        public static RecommendationDefinition updateRecommendationDefinition(string communityId,
            string recommendationDefinitionId, RecommendationDefinitionInput recommendationDefinition)
        {
            throw new global::System.NotImplementedException("Recommendations.UpdateRecommendationDefinition");
        }

        public static RecommendationDefinition updateRecommendationDefinition(string communityId,
            string recommendationDefinitionId, string name, string title, string actionUrl, string actionUrlName,
            string explanation)
        {
            throw new global::System.NotImplementedException("Recommendations.UpdateRecommendationDefinition");
        }

        public static Photo updateRecommendationDefinitionPhoto(string communityId, string recommendationDefinitionId,
            BinaryInput fileUpload)
        {
            throw new global::System.NotImplementedException("Recommendations.UpdateRecommendationDefinitionPhoto");
        }

        public static Photo updateRecommendationDefinitionPhoto(string communityId, string recommendationDefinitionId,
            string fileId, int versionNumber)
        {
            throw new global::System.NotImplementedException("Recommendations.UpdateRecommendationDefinitionPhoto");
        }

        public static Photo updateRecommendationDefinitionPhotoWithAttributes(string communityId,
            string recommendationDefinitionId, PhotoInput photo)
        {
            throw new global::System.NotImplementedException(
                "Recommendations.UpdateRecommendationDefinitionPhotoWithAttributes");
        }

        public static Photo updateRecommendationDefinitionPhotoWithAttributes(string communityId,
            string recommendationDefinitionId, PhotoInput photo, BinaryInput fileUpload)
        {
            throw new global::System.NotImplementedException(
                "Recommendations.UpdateRecommendationDefinitionPhotoWithAttributes");
        }

        public static ScheduledRecommendation updateScheduledRecommendation(string communityId,
            string scheduledRecommendationId, ScheduledRecommendationInput scheduledRecommendation)
        {
            throw new global::System.NotImplementedException("Recommendations.UpdateScheduledRecommendation");
        }

        public static ScheduledRecommendation updateScheduledRecommendation(string communityId,
            string scheduledRecommendationId, int rank, bool enabled, string recommendationAudienceId)
        {
            throw new global::System.NotImplementedException("Recommendations.UpdateScheduledRecommendation");
        }
    }
}