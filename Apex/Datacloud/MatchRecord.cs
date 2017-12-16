namespace Apex.Datacloud
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Datacloud_MatchRecord.htm#apex_class_Datacloud_MatchRecord
    /// </summary>
    public class MatchRecord
    {
        // infrastructure
        public MatchRecord(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MatchRecord));
            }
        }

        // API
        public List<AdditionalInformationMap> getAdditionalInformation()
        {
            return Self.getAdditionalInformation();
        }

        public List<FieldDiff> getFieldDiffs()
        {
            return Self.getFieldDiffs();
        }

        public double getMatchConfidence()
        {
            return Self.getMatchConfidence();
        }

        public SObject getRecord()
        {
            return Self.getRecord();
        }

        List<AdditionalInformationMap> additionalInformation
        {
            get
            {
                return Self.additionalInformation;
            }
            set
            {
                Self.additionalInformation = value;
            }
        }

        List<FieldDiff> fieldDiffs
        {
            get
            {
                return Self.fieldDiffs;
            }
            set
            {
                Self.fieldDiffs = value;
            }
        }

        double matchConfidence
        {
            get
            {
                return Self.matchConfidence;
            }
            set
            {
                Self.matchConfidence = value;
            }
        }

        SObject record
        {
            get
            {
                return Self.record;
            }
            set
            {
                Self.record = value;
            }
        }
    }
}
