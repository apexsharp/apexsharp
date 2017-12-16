namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_apexpages.htm#apex_methods_system_apexpages
    /// </summary>
    public class ApexPages
    {
        // infrastructure
        public ApexPages(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ApexPages));
            }
        }

        // API
        public void addMessage(global::Apex.ApexPages.Message message)
        {
            Self.addMessage(message);
        }

        public void addMessages(Exception exceptionThrown)
        {
            Self.addMessages(exceptionThrown);
        }

        public PageReference currentPage()
        {
            return Self.currentPage();
        }

        public global::Apex.ApexPages.Message[] getMessages()
        {
            return Self.getMessages();
        }

        public bool hasMessages()
        {
            return Self.hasMessages();
        }

        public bool hasMessages(global::Apex.ApexPages.Severity severity)
        {
            return Self.hasMessages(severity);
        }
    }
}
