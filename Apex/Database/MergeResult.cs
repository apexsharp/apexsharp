namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_database_mergeresult.htm#apex_class_database_mergeresult
    /// </summary>
    public class MergeResult
    {
        // infrastructure
        public MergeResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MergeResult));
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

        public List<string> getMergedRecordIds()
        {
            return Self.getMergedRecordIds();
        }

        public List<string> getUpdatedRelatedIds()
        {
            return Self.getUpdatedRelatedIds();
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

        List<string> mergedRecordIds
        {
            get
            {
                return Self.mergedRecordIds;
            }
            set
            {
                Self.mergedRecordIds = value;
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

        List<string> updatedRelatedIds
        {
            get
            {
                return Self.updatedRelatedIds;
            }
            set
            {
                Self.updatedRelatedIds = value;
            }
        }
    }
}
