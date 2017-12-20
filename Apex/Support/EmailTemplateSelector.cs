namespace Apex.Support
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_email_template_selector.htm#apex_email_template_selector
    /// </summary>
    public interface EmailTemplateSelector
    {
        ID getDefaultTemplateId(ID caseId);

        ID getDefaultEmailTemplateId(ID param1);
    }
}
