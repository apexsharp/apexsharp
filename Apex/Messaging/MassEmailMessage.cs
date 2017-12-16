namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_email_outbound_mass.htm#apex_classes_email_outbound_mass
    /// </summary>
    public class MassEmailMessage
    {
        // infrastructure
        public MassEmailMessage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MassEmailMessage));
            }
        }

        // API
        public MassEmailMessage()
        {
            Implementation.Constructor();
        }

        public void setDescription(string description)
        {
            Self.setDescription(description);
        }

        public void setTargetObjectIds(ID[] targetObjectIds)
        {
            Self.setTargetObjectIds(targetObjectIds);
        }

        public void setWhatIds(ID[] whatIds)
        {
            Self.setWhatIds(whatIds);
        }

        string description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
            }
        }

        List<ID> targetObjectIds
        {
            get
            {
                return Self.targetObjectIds;
            }
            set
            {
                Self.targetObjectIds = value;
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

        List<ID> whatIds
        {
            get
            {
                return Self.whatIds;
            }
            set
            {
                Self.whatIds = value;
            }
        }

        public bool getBccSender()
        {
            return Self.getBccSender();
        }

        public string getDescription()
        {
            return Self.getDescription();
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

        public List<ID> getTargetObjectIds()
        {
            return Self.getTargetObjectIds();
        }

        public ID getTemplateId()
        {
            return Self.getTemplateId();
        }

        public bool getUseSignature()
        {
            return Self.getUseSignature();
        }

        public List<ID> getWhatIds()
        {
            return Self.getWhatIds();
        }

        public void setBccSender(bool param1)
        {
            Self.setBccSender(param1);
        }

        public void setEmailPriority(string param1)
        {
            Self.setEmailPriority(param1);
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

        public void setSubject(string param1)
        {
            Self.setSubject(param1);
        }

        public void setTargetObjectIds(List<ID> param1)
        {
            Self.setTargetObjectIds(param1);
        }

        public void setTemplateId(ID param1)
        {
            Self.setTemplateId(param1);
        }

        public void setUseSignature(bool param1)
        {
            Self.setUseSignature(param1);
        }

        public void setWhatIds(List<ID> param1)
        {
            Self.setWhatIds(param1);
        }
    }
}
