namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_database_deletedrecord.htm#apex_class_database_deletedrecord
    /// </summary>
    public class DeletedRecord
    {
        // infrastructure
        public DeletedRecord(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DeletedRecord));
            }
        }

        // API
        public Date getDeletedDate()
        {
            return Self.getDeletedDate();
        }

        public ID getId()
        {
            return Self.getId();
        }

        Date deletedDate
        {
            get
            {
                return Self.deletedDate;
            }
            set
            {
                Self.deletedDate = value;
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
    }
}
