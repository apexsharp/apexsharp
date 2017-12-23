namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_email_outbound_sendemailresult.htm#apex_classes_email_outbound_sendemailresult
    /// </summary>
    public class SendEmailResult
    {
        // infrastructure
        public SendEmailResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SendEmailResult));
            }
        }

        // API
        public SendEmailError[] getErrors()
        {
            return Self.getErrors();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
        }

        List<SendEmailError> errors
        {
            get
            {
                return Self.errors;
            }
            set
            {
                Self.errors = value;
            }
        }

        bool success
        {
            get
            {
                return Self.success;
            }
            set
            {
                Self.success = value;
            }
        }
    }
}
