namespace Apex.Approval
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Approval_UnlockResult.htm#apex_class_Approval_UnlockResult
    /// </summary>
    public class UnlockResult
    {
        // infrastructure
        public UnlockResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UnlockResult));
            }
        }

        // API
        public List<Error> getErrors()
        {
            return Self.getErrors();
        }

        public ID getId()
        {
            return Self.getId();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
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
