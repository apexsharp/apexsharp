namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.ApexPages;
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
        public static void addMessage(Message message)
        {
            Implementation.addMessage(message);
        }

        public static void addMessages(Exception exceptionThrown)
        {
            Implementation.addMessages(exceptionThrown);
        }

        public static PageReference currentPage()
        {
            return Implementation.currentPage();
        }

        public List<Message> getMessages()
        {
            return Implementation.getMessages();
        }

        public static bool hasMessages()
        {
            return Implementation.hasMessages();
        }

        public bool hasMessages(Severity severity)
        {
            return Implementation.hasMessages(severity);
        }
    }
}
