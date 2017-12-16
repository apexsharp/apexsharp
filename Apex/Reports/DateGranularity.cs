namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum DateGranularity
    {
        DAY,
        DAY_IN_MONTH,
        FISCAL_PERIOD,
        FISCAL_QUARTER,
        FISCAL_WEEK,
        FISCAL_YEAR,
        MONTH,
        MONTH_IN_YEAR,
        NONE,
        QUARTER,
        WEEK,
        YEAR
    }
}
