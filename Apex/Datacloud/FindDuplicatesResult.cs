namespace Apex.Datacloud
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Datacloud_FindDuplicatesResult.htm#apex_class_Datacloud_FindDuplicatesResult
    /// </summary>
    public class FindDuplicatesResult
    {
        // infrastructure
        public FindDuplicatesResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FindDuplicatesResult));
            }
        }

        // API
        List<DuplicateResult> duplicateresults
        {
            get
            {
                return Self.duplicateresults;
            }
            set
            {
                Self.duplicateresults = value;
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

        public List<DuplicateResult> getDuplicateResults()
        {
            return Self.getDuplicateResults();
        }

        public List<Error> getErrors()
        {
            return Self.getErrors();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
        }

        List<DuplicateResult> duplicateResults
        {
            get
            {
                return Self.duplicateResults;
            }
            set
            {
                Self.duplicateResults = value;
            }
        }
    }
}
