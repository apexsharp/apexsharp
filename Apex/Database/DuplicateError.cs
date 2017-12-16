namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Datacloud;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Database_DuplicateError.htm#apex_class_Database_DuplicateError
    /// </summary>
    public class DuplicateError
    {
        // infrastructure
        public DuplicateError(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DuplicateError));
            }
        }

        // API
        public DuplicateResult getDuplicateResult()
        {
            return Self.getDuplicateResult();
        }

        public List<string> getFields()
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

        DuplicateResult duplicateResult
        {
            get
            {
                return Self.duplicateResult;
            }
            set
            {
                Self.duplicateResult = value;
            }
        }
    }
}
