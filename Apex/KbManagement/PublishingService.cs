namespace Apex.KbManagement
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_knowledge_kbManagement.htm#apex_classes_knowledge_kbManagement
    /// </summary>
    public class PublishingService
    {
        // infrastructure
        public PublishingService(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PublishingService));
            }
        }

        // API
        public static void archiveOnlineArticle(string articleId, Datetime scheduledDate)
        {
            Implementation.archiveOnlineArticle(articleId, scheduledDate);
        }

        public static void assignDraftArticleTask(string articleId, string assigneeId, string instructions, Datetime dueDate, bool sendEmailNotification)
        {
            Implementation.assignDraftArticleTask(articleId, assigneeId, instructions, dueDate, sendEmailNotification);
        }

        public static void assignDraftTranslationTask(string articleVersionId, string assigneeId, string instructions, Datetime dueDate, bool sendEmailNotification)
        {
            Implementation.assignDraftTranslationTask(articleVersionId, assigneeId, instructions, dueDate, sendEmailNotification);
        }

        public static void cancelScheduledArchivingOfArticle(string articleId)
        {
            Implementation.cancelScheduledArchivingOfArticle(articleId);
        }

        public static void cancelScheduledPublicationOfArticle(string articleId)
        {
            Implementation.cancelScheduledPublicationOfArticle(articleId);
        }

        public static void completeTranslation(string articleVersionId)
        {
            Implementation.completeTranslation(articleVersionId);
        }

        public static void deleteArchivedArticle(string articleId)
        {
            Implementation.deleteArchivedArticle(articleId);
        }

        public static void deleteArchivedArticleVersion(string articleId, int versionNumber)
        {
            Implementation.deleteArchivedArticleVersion(articleId, versionNumber);
        }

        public static void deleteDraftArticle(string articleId)
        {
            Implementation.deleteDraftArticle(articleId);
        }

        public static void deleteDraftTranslation(string articleVersionId)
        {
            Implementation.deleteDraftTranslation(articleVersionId);
        }

        public static string editArchivedArticle(string articleId)
        {
            return Implementation.editArchivedArticle(articleId);
        }

        public static string editOnlineArticle(string articleId, bool unpublish)
        {
            return Implementation.editOnlineArticle(articleId, unpublish);
        }

        public static string editPublishedTranslation(string articleId, string language, bool unpublish)
        {
            return Implementation.editPublishedTranslation(articleId, language, unpublish);
        }

        public static void publishArticle(string articleId, bool flagAsNew)
        {
            Implementation.publishArticle(articleId, flagAsNew);
        }

        public static string restoreOldVersion(string articleId, int versionNumber)
        {
            return Implementation.restoreOldVersion(articleId, versionNumber);
        }

        public static void scheduleForPublication(string articleId, Datetime scheduledDate)
        {
            Implementation.scheduleForPublication(articleId, scheduledDate);
        }

        public static void setTranslationToIncomplete(string articleVersionId)
        {
            Implementation.setTranslationToIncomplete(articleVersionId);
        }

        public static string submitForTranslation(string articleId, string language, string assigneeId, Datetime dueDate)
        {
            return Implementation.submitForTranslation(articleId, language, assigneeId, dueDate);
        }

        public PublishingService()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
