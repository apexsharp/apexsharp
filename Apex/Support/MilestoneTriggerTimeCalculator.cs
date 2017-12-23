namespace Apex.Support
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_support_milestonetriggertimecalculator.htm#apex_interface_support_milestonetriggertimecalculator
    /// </summary>
    public interface MilestoneTriggerTimeCalculator
    {
        int calculateMilestoneTriggerTime(string param1, string param2);
    }
}
