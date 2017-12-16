namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Messaging_RenderEmailTemplateBodyResult.htm#apex_class_Messaging_RenderEmailTemplateBodyResult
    /// </summary>
    public class RenderEmailTemplateBodyResult
    {
        // infrastructure
        public RenderEmailTemplateBodyResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RenderEmailTemplateBodyResult));
            }
        }

        // API
        public List<RenderEmailTemplateError> getErrors()
        {
            return Self.getErrors();
        }

        public string getMergedBody()
        {
            return Self.getMergedBody();
        }

        public bool getSuccess()
        {
            return Self.getSuccess();
        }

        List<RenderEmailTemplateError> errors
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

        string mergedBody
        {
            get
            {
                return Self.mergedBody;
            }
            set
            {
                Self.mergedBody = value;
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
