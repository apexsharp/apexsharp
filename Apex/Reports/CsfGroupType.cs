namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_enum_reports_CsfGroupType.htm
    /// </summary>
    public enum CsfGroupType
    {
        ALL,
        CUSTOM,
        GRAND_TOTAL
    }
}
