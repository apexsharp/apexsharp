namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_email_outbound_single.htm#apex_classes_outbound_single
    /// </summary>
    public class SingleEmailMessage
    {
        // infrastructure
        public SingleEmailMessage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SingleEmailMessage));
            }
        }

        // API
        public SingleEmailMessage()
        {
            Self = Implementation.Constructor();
        }

        public void setBccAddresses(string[] bccAddresses)
        {
            Self.setBccAddresses(bccAddresses);
        }

        public void setCcAddresses(string[] ccAddresses)
        {
            Self.setCcAddresses(ccAddresses);
        }

        public void setCharset(string characterSet)
        {
            Self.setCharset(characterSet);
        }

        public void setDocumentAttachments(ID[] documentIds)
        {
            Self.setDocumentAttachments(documentIds);
        }

        public void setEntityAttachments(List<string> ids)
        {
            Self.setEntityAttachments(ids);
        }

        public void setFileAttachments(EmailFileAttachment[] fileNames)
        {
            Self.setFileAttachments(fileNames);
        }

        public void setHtmlBody(string htmlBody)
        {
            Self.setHtmlBody(htmlBody);
        }

        public void setInReplyTo(string parentMessageIds)
        {
            Self.setInReplyTo(parentMessageIds);
        }

        public void setOptOutPolicy(string emailOptOutPolicy)
        {
            Self.setOptOutPolicy(emailOptOutPolicy);
        }

        public void setPlainTextBody(string plainTextBody)
        {
            Self.setPlainTextBody(plainTextBody);
        }

        public void setOrgWideEmailAddressId(ID emailAddressId)
        {
            Self.setOrgWideEmailAddressId(emailAddressId);
        }

        public void setReferences(string references)
        {
            Self.setReferences(references);
        }

        public void setSubject(string subject)
        {
            Self.setSubject(subject);
        }

        public void setTargetObjectId(ID targetObjectId)
        {
            Self.setTargetObjectId(targetObjectId);
        }

        public void setTemplateId(ID templateId)
        {
            Self.setTemplateId(templateId);
        }

        public void setToAddresses(string[] toAddresses)
        {
            Self.setToAddresses(toAddresses);
        }

        public void setTreatBodiesAsTemplate(bool treatAsTemplate)
        {
            Self.setTreatBodiesAsTemplate(treatAsTemplate);
        }

        public void setTreatTargetObjectAsRecipient(bool treatAsRecipient)
        {
            Self.setTreatTargetObjectAsRecipient(treatAsRecipient);
        }

        public void setWhatId(ID whatId)
        {
            Self.setWhatId(whatId);
        }

        List<string> bccAddresses
        {
            get
            {
                return Self.bccAddresses;
            }
            set
            {
                Self.bccAddresses = value;
            }
        }

        List<string> ccAddresses
        {
            get
            {
                return Self.ccAddresses;
            }
            set
            {
                Self.ccAddresses = value;
            }
        }

        string charset
        {
            get
            {
                return Self.charset;
            }
            set
            {
                Self.charset = value;
            }
        }

        List<string> entityAttachments
        {
            get
            {
                return Self.entityAttachments;
            }
            set
            {
                Self.entityAttachments = value;
            }
        }

        List<EmailFileAttachment> fileAttachments
        {
            get
            {
                return Self.fileAttachments;
            }
            set
            {
                Self.fileAttachments = value;
            }
        }

        string htmlBody
        {
            get
            {
                return Self.htmlBody;
            }
            set
            {
                Self.htmlBody = value;
            }
        }

        string inReplyTo
        {
            get
            {
                return Self.inReplyTo;
            }
            set
            {
                Self.inReplyTo = value;
            }
        }

        string optOutPolicy
        {
            get
            {
                return Self.optOutPolicy;
            }
            set
            {
                Self.optOutPolicy = value;
            }
        }

        ID orgWideEmailAddressId
        {
            get
            {
                return Self.orgWideEmailAddressId;
            }
            set
            {
                Self.orgWideEmailAddressId = value;
            }
        }

        string plainTextBody
        {
            get
            {
                return Self.plainTextBody;
            }
            set
            {
                Self.plainTextBody = value;
            }
        }

        string references
        {
            get
            {
                return Self.references;
            }
            set
            {
                Self.references = value;
            }
        }

        ID targetObjectId
        {
            get
            {
                return Self.targetObjectId;
            }
            set
            {
                Self.targetObjectId = value;
            }
        }

        ID templateId
        {
            get
            {
                return Self.templateId;
            }
            set
            {
                Self.templateId = value;
            }
        }

        List<string> toAddresses
        {
            get
            {
                return Self.toAddresses;
            }
            set
            {
                Self.toAddresses = value;
            }
        }

        bool treatBodiesAsTemplate
        {
            get
            {
                return Self.treatBodiesAsTemplate;
            }
            set
            {
                Self.treatBodiesAsTemplate = value;
            }
        }

        bool treatTargetObjectAsRecipient
        {
            get
            {
                return Self.treatTargetObjectAsRecipient;
            }
            set
            {
                Self.treatTargetObjectAsRecipient = value;
            }
        }

        bool userMail
        {
            get
            {
                return Self.userMail;
            }
            set
            {
                Self.userMail = value;
            }
        }

        ID whatId
        {
            get
            {
                return Self.whatId;
            }
            set
            {
                Self.whatId = value;
            }
        }

        public List<string> getBccAddresses()
        {
            return Self.getBccAddresses();
        }

        public bool getBccSender()
        {
            return Self.getBccSender();
        }

        public List<string> getCcAddresses()
        {
            return Self.getCcAddresses();
        }

        public string getCharset()
        {
            return Self.getCharset();
        }

        public string getEmailPriority()
        {
            return Self.getEmailPriority();
        }

        public List<string> getEntityAttachments()
        {
            return Self.getEntityAttachments();
        }

        public List<EmailFileAttachment> getFileAttachments()
        {
            return Self.getFileAttachments();
        }

        public string getHtmlBody()
        {
            return Self.getHtmlBody();
        }

        public string getInReplyTo()
        {
            return Self.getInReplyTo();
        }

        public string getOptOutPolicy()
        {
            return Self.getOptOutPolicy();
        }

        public ID getOrgWideEmailAddressId()
        {
            return Self.getOrgWideEmailAddressId();
        }

        public string getPlainTextBody()
        {
            return Self.getPlainTextBody();
        }

        public string getReferences()
        {
            return Self.getReferences();
        }

        public string getReplyTo()
        {
            return Self.getReplyTo();
        }

        public bool getSaveAsActivity()
        {
            return Self.getSaveAsActivity();
        }

        public string getSenderDisplayName()
        {
            return Self.getSenderDisplayName();
        }

        public string getSubject()
        {
            return Self.getSubject();
        }

        public ID getTargetObjectId()
        {
            return Self.getTargetObjectId();
        }

        public ID getTemplateId()
        {
            return Self.getTemplateId();
        }

        public List<string> getToAddresses()
        {
            return Self.getToAddresses();
        }

        public bool getUseSignature()
        {
            return Self.getUseSignature();
        }

        public ID getWhatId()
        {
            return Self.getWhatId();
        }

        public bool isTreatBodiesAsTemplate()
        {
            return Self.isTreatBodiesAsTemplate();
        }

        public bool isTreatTargetObjectAsRecipient()
        {
            return Self.isTreatTargetObjectAsRecipient();
        }

        public bool isUserMail()
        {
            return Self.isUserMail();
        }

        public void setBccAddresses(List<string> param1)
        {
            Self.setBccAddresses(param1);
        }

        public void setBccSender(bool param1)
        {
            Self.setBccSender(param1);
        }

        public void setCcAddresses(List<string> param1)
        {
            Self.setCcAddresses(param1);
        }

        public void setEmailPriority(string param1)
        {
            Self.setEmailPriority(param1);
        }

        public void setFileAttachments(List<EmailFileAttachment> param1)
        {
            Self.setFileAttachments(param1);
        }

        public void setReplyTo(string param1)
        {
            Self.setReplyTo(param1);
        }

        public void setSaveAsActivity(bool param1)
        {
            Self.setSaveAsActivity(param1);
        }

        public void setSenderDisplayName(string param1)
        {
            Self.setSenderDisplayName(param1);
        }

        public void setToAddresses(List<string> param1)
        {
            Self.setToAddresses(param1);
        }

        public void setUseSignature(bool param1)
        {
            Self.setUseSignature(param1);
        }
    }
}
