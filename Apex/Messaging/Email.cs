namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_email_outbound_base.htm#apex_classes_email_outbound_base
    /// </summary>
    public class Email
    {
        // infrastructure
        public Email(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Email));
            }
        }

        // API
        public void setBccSender(bool bcc)
        {
            Self.setBccSender(bcc);
        }

        public void setReplyTo(string replyAddress)
        {
            Self.setReplyTo(replyAddress);
        }

        public void setTemplateID(ID templateId)
        {
            Self.setTemplateID(templateId);
        }

        public void setSaveAsActivity(bool saveAsActivity)
        {
            Self.setSaveAsActivity(saveAsActivity);
        }

        public void setSenderDisplayName(string displayName)
        {
            Self.setSenderDisplayName(displayName);
        }

        public void setUseSignature(bool useSignature)
        {
            Self.setUseSignature(useSignature);
        }

        bool bccSender
        {
            get
            {
                return Self.bccSender;
            }
            set
            {
                Self.bccSender = value;
            }
        }

        string emailPriority
        {
            get
            {
                return Self.emailPriority;
            }
            set
            {
                Self.emailPriority = value;
            }
        }

        string replyTo
        {
            get
            {
                return Self.replyTo;
            }
            set
            {
                Self.replyTo = value;
            }
        }

        bool saveAsActivity
        {
            get
            {
                return Self.saveAsActivity;
            }
            set
            {
                Self.saveAsActivity = value;
            }
        }

        string senderDisplayName
        {
            get
            {
                return Self.senderDisplayName;
            }
            set
            {
                Self.senderDisplayName = value;
            }
        }

        string subject
        {
            get
            {
                return Self.subject;
            }
            set
            {
                Self.subject = value;
            }
        }

        bool useSignature
        {
            get
            {
                return Self.useSignature;
            }
            set
            {
                Self.useSignature = value;
            }
        }

        public bool getBccSender()
        {
            return Self.getBccSender();
        }

        public string getEmailPriority()
        {
            return Self.getEmailPriority();
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

        public bool getUseSignature()
        {
            return Self.getUseSignature();
        }

        public void setEmailPriority(string param1)
        {
            Self.setEmailPriority(param1);
        }

        public void setSubject(string param1)
        {
            Self.setSubject(param1);
        }
    }
}
