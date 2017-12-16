namespace Apex.TerritoryMgmt
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_TerritoryMgmt_OpportunityTerritory2AssignmentFilter.htm#apex_interface_TerritoryMgmt_OpportunityTerritory2AssignmentFilter
    /// </summary>
    public interface OpportunityTerritory2AssignmentFilter
    {
        Map<ID, ID> getOpportunityTerritory2Assignments(List<ID> opportunityIds);
    }
}
