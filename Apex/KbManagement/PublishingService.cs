using Apex.System;

namespace Apex.KbManagement
{
    public class PublishingService
    {
        public PublishingService()
        {
            throw new global::System.NotImplementedException("PublishingService");
        }

        public static void archiveOnlineArticle(string articleId, DateTime scheduledDate)
        {
            throw new global::System.NotImplementedException("PublishingService.ArchiveOnlineArticle");
        }

        public static void assignDraftArticleTask(string articleId, string assigneeId, string instructions,
            DateTime dueDate, bool sendEmailNotification)
        {
            throw new global::System.NotImplementedException("PublishingService.AssignDraftArticleTask");
        }

        public static void assignDraftTranslationTask(string translationVersionId, string assigneeId,
            string instructions, DateTime dueDate, bool sendEmailNotification)
        {
            throw new global::System.NotImplementedException("PublishingService.AssignDraftTranslationTask");
        }

        public static void cancelScheduledArchivingOfArticle(string articleId)
        {
            throw new global::System.NotImplementedException("PublishingService.CancelScheduledArchivingOfArticle");
        }

        public static void cancelScheduledPublicationOfArticle(string articleId)
        {
            throw new global::System.NotImplementedException("PublishingService.CancelScheduledPublicationOfArticle");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("PublishingService.Clone");
        }

        public static void completeTranslation(string articleVersionId)
        {
            throw new global::System.NotImplementedException("PublishingService.CompleteTranslation");
        }

        public static void deleteArchivedArticle(string articleId)
        {
            throw new global::System.NotImplementedException("PublishingService.DeleteArchivedArticle");
        }

        public static void deleteArchivedArticleVersion(string articleId, int versionNumber)
        {
            throw new global::System.NotImplementedException("PublishingService.DeleteArchivedArticleVersion");
        }

        public static void deleteDraftArticle(string articleId)
        {
            throw new global::System.NotImplementedException("PublishingService.DeleteDraftArticle");
        }

        public static void deleteDraftTranslation(string articleVersionId)
        {
            throw new global::System.NotImplementedException("PublishingService.DeleteDraftTranslation");
        }

        public static string editArchivedArticle(string articleId)
        {
            throw new global::System.NotImplementedException("PublishingService.EditArchivedArticle");
        }

        public static string editOnlineArticle(string articleId, bool unpublish)
        {
            throw new global::System.NotImplementedException("PublishingService.EditOnlineArticle");
        }

        public static string editPublishedTranslation(string articleId, string language, bool unpublish)
        {
            throw new global::System.NotImplementedException("PublishingService.EditPublishedTranslation");
        }

        public static void publishArticle(string articleId, bool flagAsNew)
        {
            throw new global::System.NotImplementedException("PublishingService.PublishArticle");
        }

        public static string restoreOldVersion(string articleId, int versionNumber)
        {
            throw new global::System.NotImplementedException("PublishingService.RestoreOldVersion");
        }

        public static void scheduleForPublication(string articleId, DateTime scheduledDate)
        {
            throw new global::System.NotImplementedException("PublishingService.ScheduleForPublication");
        }

        public static void setTranslationToIncomplete(string articleVersionId)
        {
            throw new global::System.NotImplementedException("PublishingService.SetTranslationToIncomplete");
        }

        public static string submitForTranslation(string articleId, string language, string assigneeId,
            DateTime dueDate)
        {
            throw new global::System.NotImplementedException("PublishingService.SubmitForTranslation");
        }
    }
}