namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Zones_static_methods.htm#apex_ConnectAPI_Zones_static_methods
    /// </summary>
    public class Zones
    {
        // infrastructure
        public Zones(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Zones));
            }
        }

        // API
        public static Zone getZone(string communityId, string zoneId)
        {
            return Implementation.getZone(communityId, zoneId);
        }

        public static ZonePage getZones(string communityId)
        {
            return Implementation.getZones(communityId);
        }

        public static Zone getZones(string communityId, int pageParam, int pageSize)
        {
            return Implementation.getZones(communityId, pageParam, pageSize);
        }

        public static ZoneSearchPage searchInZone(string communityId, string zoneId, string q, ZoneSearchResultType filter)
        {
            return Implementation.searchInZone(communityId, zoneId, q, filter);
        }

        public static ZoneSearchPage searchInZone(string communityId, string zoneId, string q, ZoneSearchResultType filter, string pageParam, int pageSize)
        {
            return Implementation.searchInZone(communityId, zoneId, q, filter, pageParam, pageSize);
        }

        public static ZoneSearchPage searchInZone(string communityId, string zoneId, string q, ZoneSearchResultType filter, string language)
        {
            return Implementation.searchInZone(communityId, zoneId, q, filter, language);
        }

        public static void setTestSearchInZone(string communityId, string zoneId, string q, ZoneSearchResultType filter, ZoneSearchPage result)
        {
            Implementation.setTestSearchInZone(communityId, zoneId, q, filter, result);
        }

        public static void setTestSearchInZone(string communityId, string zoneId, string q, ZoneSearchResultType filter, string pageParam, int pageSize, ZoneSearchPage result)
        {
            Implementation.setTestSearchInZone(communityId, zoneId, q, filter, pageParam, pageSize, result);
        }

        public static void setTestSearchInZone(string communityId, string zoneId, string q, ZoneSearchResultType filter, string language, ZoneSearchPage result)
        {
            Implementation.setTestSearchInZone(communityId, zoneId, q, filter, language, result);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
