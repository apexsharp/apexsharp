namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.Messaging;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_email_outbound_messaging.htm#apex_classes_email_outbound_messaging
    /// </summary>
    public class Messaging
    {
        // infrastructure
        public Messaging(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Messaging));
            }
        }

        // API
        public static InboundEmail extractInboundEmail(object source, bool includeForwardedAttachments)
        {
            return Implementation.extractInboundEmail(source, includeForwardedAttachments);
        }

        public void reserveMassEmailCapacity(int amountReserved)
        {
            Self.reserveMassEmailCapacity(amountReserved);
        }

        public void reserveSingleEmailCapacity(int amountReserved)
        {
            Self.reserveSingleEmailCapacity(amountReserved);
        }

        public SendEmailResult[] sendEmail(Email[] emails, bool allOrNothing)
        {
            return Self.sendEmail(emails, allOrNothing);
        }

        public SendEmailResult[] sendEmailMessage(List<ID> emailMessageIds, bool allOrNothing)
        {
            return Self.sendEmailMessage(emailMessageIds, allOrNothing);
        }

        public static List<RenderEmailTemplateBodyResult> renderEmailTemplate(string whoId, string whatId, List<string> bodies)
        {
            return Implementation.renderEmailTemplate(whoId, whatId, bodies);
        }

        public static SingleEmailMessage renderStoredEmailTemplate(string templateId, string whoId, string whatId)
        {
            return Implementation.renderStoredEmailTemplate(templateId, whoId, whatId);
        }

        public static SingleEmailMessage renderStoredEmailTemplate(string templateId, string whoId, string whatId, AttachmentRetrievalOption attachmentRetrievalOption)
        {
            return Implementation.renderStoredEmailTemplate(templateId, whoId, whatId, attachmentRetrievalOption);
        }

        public static SingleEmailMessage renderStoredEmailTemplate(string templateId, string whoId, string whatId, object attachmentRetrievalOption)
        {
            return Implementation.renderStoredEmailTemplate(templateId, whoId, whatId, attachmentRetrievalOption);
        }

        public static List<SendEmailResult> sendEmail(List<Email> emailMessages, bool allOrNothing)
        {
            return Implementation.sendEmail(emailMessages, allOrNothing);
        }

        public static List<SendEmailResult> sendEmail(List<Email> emailMessages)
        {
            return Implementation.sendEmail(emailMessages);
        }

        public static List<SendEmailResult> sendEmailMessage(List<ID> emailMessagesIds)
        {
            return Implementation.sendEmailMessage(emailMessagesIds);
        }
    }
}
