namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Datacloud;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MergeRequest
    {
        // infrastructure
        public MergeRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MergeRequest));
            }
        }

        // API
        List<AdditionalInformationMap> additionalInformationMap
        {
            get
            {
                return Self.additionalInformationMap;
            }
            set
            {
                Self.additionalInformationMap = value;
            }
        }

        SObject masterRecord
        {
            get
            {
                return Self.masterRecord;
            }
            set
            {
                Self.masterRecord = value;
            }
        }

        List<string> recordToMergeIds
        {
            get
            {
                return Self.recordToMergeIds;
            }
            set
            {
                Self.recordToMergeIds = value;
            }
        }

        public MergeRequest()
        {
            Implementation.Constructor();
        }

        public List<AdditionalInformationMap> getAdditionalInformationMap()
        {
            return Self.getAdditionalInformationMap();
        }

        public SObject getMasterRecord()
        {
            return Self.getMasterRecord();
        }

        public List<string> getRecordToMergeIds()
        {
            return Self.getRecordToMergeIds();
        }

        public void setAdditionalInformationMap(List<AdditionalInformationMap> param1)
        {
            Self.setAdditionalInformationMap(param1);
        }

        public void setMasterRecord(SObject param1)
        {
            Self.setMasterRecord(param1);
        }

        public void setRecordToMergeIds(List<string> param1)
        {
            Self.setRecordToMergeIds(param1);
        }
    }
}
