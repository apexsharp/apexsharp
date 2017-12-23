namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Recommendations_static_methods.htm#apex_ConnectAPI_Recommendations_static_methods
    /// </summary>
    public class Recommendations
    {
        // infrastructure
        public Recommendations(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Recommendations));
            }
        }

        // API
        public static RecommendationAudience createRecommendationAudience(string communityId, RecommendationAudienceInput recommendationAudience)
        {
            return Implementation.createRecommendationAudience(communityId, recommendationAudience);
        }

        public static RecommendationAudience createRecommendationAudience(string communityId, string name)
        {
            return Implementation.createRecommendationAudience(communityId, name);
        }

        public static RecommendationDefinition createRecommendationDefinition(string communityId, RecommendationDefinitionInput recommendationDefinition)
        {
            return Implementation.createRecommendationDefinition(communityId, recommendationDefinition);
        }

        public static RecommendationDefinition createRecommendationDefinition(string communityId, string name, string title, string actionUrl, string actionUrlName, string explanation)
        {
            return Implementation.createRecommendationDefinition(communityId, name, title, actionUrl, actionUrlName, explanation);
        }

        public static ScheduledRecommendation createScheduledRecommendation(string communityId, ScheduledRecommendationInput scheduledRecommendation)
        {
            return Implementation.createScheduledRecommendation(communityId, scheduledRecommendation);
        }

        public static ScheduledRecommendation createScheduledRecommendation(string communityId, string recommendationDefinitionId, int rank, bool enabled, string recommendationAudienceId)
        {
            return Implementation.createScheduledRecommendation(communityId, recommendationDefinitionId, rank, enabled, recommendationAudienceId);
        }

        public static ScheduledRecommendation createScheduledRecommendation(string communityId, string recommendationDefinitionId, int rank, bool enabled, string recommendationAudienceId, RecommendationChannel channel)
        {
            return Implementation.createScheduledRecommendation(communityId, recommendationDefinitionId, rank, enabled, recommendationAudienceId, channel);
        }

        public static void deleteRecommendationAudience(string communityId, string recommendationAudienceId)
        {
            Implementation.deleteRecommendationAudience(communityId, recommendationAudienceId);
        }

        public static void deleteRecommendationDefinition(string communityId, string recommendationDefinitionId)
        {
            Implementation.deleteRecommendationDefinition(communityId, recommendationDefinitionId);
        }

        public static void deleteRecommendationDefinitionPhoto(string communityId, string recommendationDefinitionId)
        {
            Implementation.deleteRecommendationDefinitionPhoto(communityId, recommendationDefinitionId);
        }

        public static void deleteScheduledRecommendation(string communityId, string scheduledRecommendationId, bool deleteDefinitionIfLast)
        {
            Implementation.deleteScheduledRecommendation(communityId, scheduledRecommendationId, deleteDefinitionIfLast);
        }

        public static RecommendationAudience getRecommendationAudience(string communityId, string recommendationAudienceId)
        {
            return Implementation.getRecommendationAudience(communityId, recommendationAudienceId);
        }

        public static UserReferencePage getRecommendationAudienceMembership(string communityId, string recommendationAudienceId)
        {
            return Implementation.getRecommendationAudienceMembership(communityId, recommendationAudienceId);
        }

        public static UserReferencePage getRecommendationAudienceMembership(string communityId, string recommendationAudienceId, int pageParam, int pageSize)
        {
            return Implementation.getRecommendationAudienceMembership(communityId, recommendationAudienceId, pageParam, pageSize);
        }

        public static RecommendationAudiencePage getRecommendationAudiences(string communityId)
        {
            return Implementation.getRecommendationAudiences(communityId);
        }

        public static RecommendationAudiencePage getRecommendationAudiences(string communityId, int pageParam, int pageSize)
        {
            return Implementation.getRecommendationAudiences(communityId, pageParam, pageSize);
        }

        public static RecommendationDefinition getRecommendationDefinition(string communityId, string recommendationDefinitionId)
        {
            return Implementation.getRecommendationDefinition(communityId, recommendationDefinitionId);
        }

        public static Photo getRecommendationDefinitionPhoto(string communityId, string recommendationDefinitionId)
        {
            return Implementation.getRecommendationDefinitionPhoto(communityId, recommendationDefinitionId);
        }

        public static RecommendationDefinitionPage getRecommendationDefinitions(string communityId)
        {
            return Implementation.getRecommendationDefinitions(communityId);
        }

        public static RecommendationCollection getRecommendationForUser(string communityId, string userId, RecommendationActionType action, string objectId)
        {
            return Implementation.getRecommendationForUser(communityId, userId, action, objectId);
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId, RecommendationActionType contextAction, string contextObjectId, int maxResults)
        {
            return Implementation.getRecommendationsForUser(communityId, userId, contextAction, contextObjectId, maxResults);
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId, RecommendationActionType contextAction, string contextObjectId, RecommendationChannel channel, int maxResults)
        {
            return Implementation.getRecommendationsForUser(communityId, userId, contextAction, contextObjectId, channel, maxResults);
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId, RecommendationActionType action, RecommendationActionType contextAction, string contextObjectId, int maxResults)
        {
            return Implementation.getRecommendationsForUser(communityId, userId, action, contextAction, contextObjectId, maxResults);
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId, RecommendationActionType action, RecommendationActionType contextAction, string contextObjectId, RecommendationChannel channel, int maxResults)
        {
            return Implementation.getRecommendationsForUser(communityId, userId, action, contextAction, contextObjectId, channel, maxResults);
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId, RecommendationActionType action, string objectCategory, RecommendationActionType contextAction, string contextObjectId, int maxResults)
        {
            return Implementation.getRecommendationsForUser(communityId, userId, action, objectCategory, contextAction, contextObjectId, maxResults);
        }

        public static RecommendationCollection getRecommendationsForUser(string communityId, string userId, RecommendationActionType action, string objectCategory, RecommendationActionType contextAction, string contextObjectId, RecommendationChannel channel, int maxResults)
        {
            return Implementation.getRecommendationsForUser(communityId, userId, action, objectCategory, contextAction, contextObjectId, channel, maxResults);
        }

        public static ScheduledRecommendation getScheduledRecommendation(string communityId, string scheduledRecommendationId)
        {
            return Implementation.getScheduledRecommendation(communityId, scheduledRecommendationId);
        }

        public static ScheduledRecommendationPage getScheduledRecommendations(string communityId)
        {
            return Implementation.getScheduledRecommendations(communityId);
        }

        public static ScheduledRecommendationPage getScheduledRecommendations(string communityId, RecommendationChannel channel)
        {
            return Implementation.getScheduledRecommendations(communityId, channel);
        }

        public static void rejectRecommendationForUser(string communityId, string userId, RecommendationActionType action, string objectId)
        {
            Implementation.rejectRecommendationForUser(communityId, userId, action, objectId);
        }

        public static void rejectRecommendationForUser(string communityId, string userId, RecommendationActionType action, RecommendedObjectType objectEnum)
        {
            Implementation.rejectRecommendationForUser(communityId, userId, action, objectEnum);
        }

        public static RecommendationAudience updateRecommendationAudience(string communityId, string recommendationAudienceId, RecommendationAudienceInput recommendationAudience)
        {
            return Implementation.updateRecommendationAudience(communityId, recommendationAudienceId, recommendationAudience);
        }

        public static RecommendationDefinition updateRecommendationDefinition(string communityId, string recommendationDefinitionId, string name, string title, string actionUrl, string actionUrlName, string explanation)
        {
            return Implementation.updateRecommendationDefinition(communityId, recommendationDefinitionId, name, title, actionUrl, actionUrlName, explanation);
        }

        public static RecommendationDefinition updateRecommendationDefinition(string communityId, string recommendationDefinitionId, RecommendationDefinitionInput recommendationDefinition)
        {
            return Implementation.updateRecommendationDefinition(communityId, recommendationDefinitionId, recommendationDefinition);
        }

        public static Photo updateRecommendationDefinitionPhoto(string communityId, string recommendationDefinitionId, BinaryInput fileUpload)
        {
            return Implementation.updateRecommendationDefinitionPhoto(communityId, recommendationDefinitionId, fileUpload);
        }

        public static Photo updateRecommendationDefinitionPhoto(string communityId, string recommendationDefinitionId, string fileId, int versionNumber)
        {
            return Implementation.updateRecommendationDefinitionPhoto(communityId, recommendationDefinitionId, fileId, versionNumber);
        }

        public static Photo updateRecommendationDefinitionPhotoWithAttributes(string communityId, string recommendationDefinitionId, PhotoInput photo)
        {
            return Implementation.updateRecommendationDefinitionPhotoWithAttributes(communityId, recommendationDefinitionId, photo);
        }

        public static Photo updateRecommendationDefinitionPhotoWithAttributes(string communityId, string recommendationDefinitionId, PhotoInput photo, BinaryInput fileUpload)
        {
            return Implementation.updateRecommendationDefinitionPhotoWithAttributes(communityId, recommendationDefinitionId, photo, fileUpload);
        }

        public static ScheduledRecommendation updateScheduledRecommendation(string communityId, string scheduledRecommendationId, ScheduledRecommendationInput scheduledRecommendation)
        {
            return Implementation.updateScheduledRecommendation(communityId, scheduledRecommendationId, scheduledRecommendation);
        }

        public static ScheduledRecommendation updateScheduledRecommendation(string communityId, string scheduledRecommendationId, int rank, bool enabled, string recommendationAudienceId)
        {
            return Implementation.updateScheduledRecommendation(communityId, scheduledRecommendationId, rank, enabled, recommendationAudienceId);
        }

        public static void setTestGetRecommendationForUser(string communityId, string userId, RecommendationActionType action, string objectId, RecommendationCollection result)
        {
            Implementation.setTestGetRecommendationForUser(communityId, userId, action, objectId, result);
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId, RecommendationActionType contextAction, string contextObjectId, int maxResults, RecommendationCollection result)
        {
            Implementation.setTestGetRecommendationsForUser(communityId, userId, contextAction, contextObjectId, maxResults, result);
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId, RecommendationActionType contextAction, string contextObjectId, RecommendationChannel channel, int maxResults, RecommendationCollection result)
        {
            Implementation.setTestGetRecommendationsForUser(communityId, userId, contextAction, contextObjectId, channel, maxResults, result);
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId, RecommendationActionType action, RecommendationActionType contextAction, string contextObjectId, int maxResults, RecommendationCollection result)
        {
            Implementation.setTestGetRecommendationsForUser(communityId, userId, action, contextAction, contextObjectId, maxResults, result);
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId, RecommendationActionType action, RecommendationActionType contextAction, string contextObjectId, RecommendationChannel channel, int maxResults, RecommendationCollection result)
        {
            Implementation.setTestGetRecommendationsForUser(communityId, userId, action, contextAction, contextObjectId, channel, maxResults, result);
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId, RecommendationActionType action, string objectCategory, RecommendationActionType contextAction, string contextObjectId, int maxResults, RecommendationCollection result)
        {
            Implementation.setTestGetRecommendationsForUser(communityId, userId, action, objectCategory, contextAction, contextObjectId, maxResults, result);
        }

        public static void setTestGetRecommendationsForUser(string communityId, string userId, RecommendationActionType action, string objectCategory, RecommendationActionType contextAction, string contextObjectId, RecommendationChannel channel, int maxResults, RecommendationCollection result)
        {
            Implementation.setTestGetRecommendationsForUser(communityId, userId, action, objectCategory, contextAction, contextObjectId, channel, maxResults, result);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
