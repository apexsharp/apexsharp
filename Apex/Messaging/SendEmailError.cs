namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_email_outbound_sendemailerror.htm#apex_classes_email_outbound_sendemailerror
    /// </summary>
    public class SendEmailError
    {
        // infrastructure
        public SendEmailError(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SendEmailError));
            }
        }

        // API
        public string[] getFields()
        {
            return Self.getFields();
        }

        public string getMessage()
        {
            return Self.getMessage();
        }

        public StatusCode getStatusCode()
        {
            return Self.getStatusCode();
        }

        public string getTargetObjectId()
        {
            return Self.getTargetObjectId();
        }

        string message
        {
            get
            {
                return Self.message;
            }
            set
            {
                Self.message = value;
            }
        }

        StatusCode statusCode
        {
            get
            {
                return Self.statusCode;
            }
            set
            {
                Self.statusCode = value;
            }
        }

        string targetObjectId
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
    }
}
