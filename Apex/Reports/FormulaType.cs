namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_enum_reports_FormulaType.htm
    /// </summary>
    public enum FormulaType
    {
        CURRENCY,
        NUMBER,
        PERCENT
    }
}
