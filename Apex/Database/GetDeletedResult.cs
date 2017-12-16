namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_database_getdeletedresult.htm#apex_class_database_getdeletedresult
    /// </summary>
    public class GetDeletedResult
    {
        // infrastructure
        public GetDeletedResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(GetDeletedResult));
            }
        }

        // API
        public List<DeletedRecord> getDeletedRecords()
        {
            return Self.getDeletedRecords();
        }

        public Date getEarliestDateAvailable()
        {
            return Self.getEarliestDateAvailable();
        }

        public Date getLatestDateCovered()
        {
            return Self.getLatestDateCovered();
        }

        List<DeletedRecord> deletedRecords
        {
            get
            {
                return Self.deletedRecords;
            }
            set
            {
                Self.deletedRecords = value;
            }
        }

        Date earliestDateAvailable
        {
            get
            {
                return Self.earliestDateAvailable;
            }
            set
            {
                Self.earliestDateAvailable = value;
            }
        }

        Date latestDateCovered
        {
            get
            {
                return Self.latestDateCovered;
            }
            set
            {
                Self.latestDateCovered = value;
            }
        }
    }
}
