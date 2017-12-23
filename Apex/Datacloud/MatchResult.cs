namespace Apex.Datacloud
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Datacloud_MatchResult.htm#apex_class_Datacloud_MatchResult
    /// </summary>
    public class MatchResult
    {
        // infrastructure
        public MatchResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MatchResult));
            }
        }

        // API
        public string getEntityType()
        {
            return Self.getEntityType();
        }

        public List<Error> getErrors()
        {
            return Self.getErrors();
        }

        public string getMatchEngine()
        {
            return Self.getMatchEngine();
        }

        public List<MatchRecord> getMatchRecords()
        {
            return Self.getMatchRecords();
        }

        public string getRule()
        {
            return Self.getRule();
        }

        public int getSize()
        {
            return Self.getSize();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
        }

        string entityType
        {
            get
            {
                return Self.entityType;
            }
            set
            {
                Self.entityType = value;
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

        string matchEngine
        {
            get
            {
                return Self.matchEngine;
            }
            set
            {
                Self.matchEngine = value;
            }
        }

        List<MatchRecord> matchRecords
        {
            get
            {
                return Self.matchRecords;
            }
            set
            {
                Self.matchRecords = value;
            }
        }

        string rule
        {
            get
            {
                return Self.rule;
            }
            set
            {
                Self.rule = value;
            }
        }

        int size
        {
            get
            {
                return Self.size;
            }
            set
            {
                Self.size = value;
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
