namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_database_getupdatedresult.htm#apex_class_database_getupdatedresult
    /// </summary>
    public class GetUpdatedResult
    {
        // infrastructure
        public GetUpdatedResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(GetUpdatedResult));
            }
        }

        // API
        public List<ID> getIds()
        {
            return Self.getIds();
        }

        public Date getLatestDateCovered()
        {
            return Self.getLatestDateCovered();
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
