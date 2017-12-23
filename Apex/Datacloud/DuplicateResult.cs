namespace Apex.Datacloud
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Datacloud_DuplicateResult.htm#apex_class_Datacloud_DuplicateResult
    /// </summary>
    public class DuplicateResult
    {
        // infrastructure
        public DuplicateResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DuplicateResult));
            }
        }

        // API
        public string getDuplicateRule()
        {
            return Self.getDuplicateRule();
        }

        public string getErrorMessage()
        {
            return Self.getErrorMessage();
        }

        public List<MatchResult> getMatchResults()
        {
            return Self.getMatchResults();
        }

        public bool isAllowSave()
        {
            return Self.isAllowSave();
        }

        bool allowSave
        {
            get
            {
                return Self.allowSave;
            }
            set
            {
                Self.allowSave = value;
            }
        }

        string duplicateRule
        {
            get
            {
                return Self.duplicateRule;
            }
            set
            {
                Self.duplicateRule = value;
            }
        }

        string duplicateRuleEntityType
        {
            get
            {
                return Self.duplicateRuleEntityType;
            }
            set
            {
                Self.duplicateRuleEntityType = value;
            }
        }

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

        List<MatchResult> matchResults
        {
            get
            {
                return Self.matchResults;
            }
            set
            {
                Self.matchResults = value;
            }
        }

        public string getDuplicateRuleEntityType()
        {
            return Self.getDuplicateRuleEntityType();
        }
    }
}
