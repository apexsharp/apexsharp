using Apex.Messaging;


namespace Apex.System
{
    public class Messaging
    {
        public static List<RenderEmailTemplateBodyResult> renderEmailTemplate(string whoId, string whatId,
            List<string> bodies)
        {
            throw new global::System.NotImplementedException("Messaging.RenderEmailTemplate");
        }

        public static SingleEmailMessage renderStoredEmailTemplate(string templateId, string whoId, string whatId)
        {
            throw new global::System.NotImplementedException("Messaging.RenderStoredEmailTemplate");
        }

        public static void reserveMassEmailCapacity(int count)
        {
            throw new global::System.NotImplementedException("Messaging.ReserveMassEmailCapacity");
        }

        public static void reserveSingleEmailCapacity(int count)
        {
            throw new global::System.NotImplementedException("Messaging.ReserveSingleEmailCapacity");
        }

        public static List<SendEmailResult> sendEmail(List<Email> emailMessages)
        {
            throw new global::System.NotImplementedException("Messaging.SendEmail");
        }

        public static List<SendEmailResult> sendEmail(List<Email> emailMessages, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Messaging.SendEmail");
        }

        public static List<SendEmailResult> sendEmailMessage(List<ID> emailMessagesIds)
        {
            throw new global::System.NotImplementedException("Messaging.SendEmailMessage");
        }

        public static List<SendEmailResult> sendEmailMessage(List<ID> emailMessagesIds, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Messaging.SendEmailMessage");
        }
    }
}