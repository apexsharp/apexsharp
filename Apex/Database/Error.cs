namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_database_error.htm#apex_methods_system_database_error
    /// </summary>
    public class Error
    {
        // infrastructure
        public Error(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Error));
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

        List<string> fields
        {
            get
            {
                return Self.fields;
            }
            set
            {
                Self.fields = value;
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
