using Apex.System;

using SObject = Apex.System.SObject;

namespace Apex.Datacloud
{
    public class MatchRecord
    {
        public List<Datacloud.AdditionalInformationMap> getAdditionalInformation()
        {
            throw new global::System.NotImplementedException("MatchRecord.GetAdditionalInformation");
        }

        public List<Datacloud.FieldDiff> getFieldDiffs()
        {
            throw new global::System.NotImplementedException("MatchRecord.GetFieldDiffs");
        }

        public double getMatchConfidence()
        {
            throw new global::System.NotImplementedException("MatchRecord.GetMatchConfidence");
        }

        public SObject getRecord()
        {
            throw new global::System.NotImplementedException("MatchRecord.GetRecord");
        }
    }
}