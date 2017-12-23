namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Messaging_RenderEmailTemplateError.htm#apex_class_Messaging_RenderEmailTemplateError
    /// </summary>
    public class RenderEmailTemplateError
    {
        // infrastructure
        public RenderEmailTemplateError(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RenderEmailTemplateError));
            }
        }

        // API
        public string getFieldName()
        {
            return Self.getFieldName();
        }

        public string getMessage()
        {
            return Self.getMessage();
        }

        public int getOffset()
        {
            return Self.getOffset();
        }

        public StatusCode getStatusCode()
        {
            return Self.getStatusCode();
        }

        string fieldName
        {
            get
            {
                return Self.fieldName;
            }
            set
            {
                Self.fieldName = value;
            }
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

        int offset
        {
            get
            {
                return Self.offset;
            }
            set
            {
                Self.offset = value;
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
    }
}
