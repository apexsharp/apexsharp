namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_database_upsertresult.htm#apex_methods_system_database_upsertresult
    /// </summary>
    public class UpsertResult
    {
        // infrastructure
        public UpsertResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UpsertResult));
            }
        }

        // API
        public Error[] getErrors()
        {
            return Self.getErrors();
        }

        public ID getId()
        {
            return Self.getId();
        }

        public bool isCreated()
        {
            return Self.isCreated();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
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

        ID id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
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
