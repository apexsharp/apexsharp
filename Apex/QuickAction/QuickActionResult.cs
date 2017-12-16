namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_quickaction_quickactionresult.htm#apex_class_quickaction_quickactionresult
    /// </summary>
    public class QuickActionResult
    {
        // infrastructure
        public QuickActionResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuickActionResult));
            }
        }

        // API
        public List<Error> getErrors()
        {
            return Self.getErrors();
        }

        public List<ID> getIds()
        {
            return Self.getIds();
        }

        public string getSuccessMessage()
        {
            return Self.getSuccessMessage();
        }

        public bool isCreated()
        {
            return Self.isCreated();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
        }

        ID contextId
        {
            get
            {
                return Self.contextId;
            }
            set
            {
                Self.contextId = value;
            }
        }

        bool created
        {
            get
            {
                return Self.created;
            }
            set
            {
                Self.created = value;
            }
        }

        List<Error> errors
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

        List<ID> ids
        {
            get
            {
                return Self.ids;
            }
            set
            {
                Self.ids = value;
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

        string successMessage
        {
            get
            {
                return Self.successMessage;
            }
            set
            {
                Self.successMessage = value;
            }
        }

        public ID getContextId()
        {
            return Self.getContextId();
        }
    }
}
