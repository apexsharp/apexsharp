namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_QuickAction_SendEmailQuickActionDefaults.htm#apex_class_QuickAction_SendEmailQuickActionDefaults
    /// </summary>
    public class SendEmailQuickActionDefaults
    {
        // infrastructure
        public SendEmailQuickActionDefaults(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SendEmailQuickActionDefaults));
            }
        }

        // API
        public List<string> getFromAddressList()
        {
            return Self.getFromAddressList();
        }

        public ID getInReplyToId()
        {
            return Self.getInReplyToId();
        }

        public void setIgnoreTemplateSubject(bool useOriginalSubject)
        {
            Self.setIgnoreTemplateSubject(useOriginalSubject);
        }

        public void setInsertTemplateBody(bool keepOriginalBodyContent)
        {
            Self.setInsertTemplateBody(keepOriginalBodyContent);
        }

        public void setTemplateId(ID templateId)
        {
            Self.setTemplateId(templateId);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getActionName()
        {
            return Self.getActionName();
        }

        public string getActionType()
        {
            return Self.getActionType();
        }

        public ID getContextId()
        {
            return Self.getContextId();
        }

        public SObject getTargetSObject()
        {
            return Self.getTargetSObject();
        }
    }
}
