namespace Apex.ApexPages
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_pages_message.htm#apex_pages_message
    /// </summary>
    public class Message
    {
        // infrastructure
        public Message(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Message));
            }
        }

        // API
        public Message(Severity severity, string summary)
        {
            Implementation.Constructor(severity, summary);
        }

        public Message(Severity severity, string summary, string detail)
        {
            Implementation.Constructor(severity, summary, detail);
        }

        public Message(Severity severity, string summary, string detail, string id)
        {
            Implementation.Constructor(severity, summary, detail, id);
        }

        public string getComponentLabel()
        {
            return Self.getComponentLabel();
        }

        public string getDetail()
        {
            return Self.getDetail();
        }

        public Severity getSeverity()
        {
            return Self.getSeverity();
        }

        public string getSummary()
        {
            return Self.getSummary();
        }
    }
}
