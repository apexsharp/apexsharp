namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_UpsertResult.htm#apex_class_DataSource_UpsertResult
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
        string errorMessage
        {
            get
            {
                return Self.errorMessage;
            }
            set
            {
                Self.errorMessage = value;
            }
        }

        string externalId
        {
            get
            {
                return Self.externalId;
            }
            set
            {
                Self.externalId = value;
            }
        }

        bool Success
        {
            get
            {
                return Self.Success;
            }
            set
            {
                Self.Success = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public static UpsertResult failure(string externalId, string errorMessage)
        {
            return Implementation.failure(externalId, errorMessage);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public static UpsertResult success(string externalId)
        {
            return Implementation.success(externalId);
        }
    }
}
